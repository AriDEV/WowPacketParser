﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;
using WowPacketParser.Enums.Version;
using WowPacketParser.Misc;

namespace WowPacketParser.Saving
{
    public static class SplitBinaryPacketWriter
    {
        private const string Folder = "split"; // might want to move to config later
        private static Encoding Encoding;

        public static void Write(IEnumerable<Packet> packets, Encoding encoding)
        {
            Encoding = encoding;
            Directory.CreateDirectory(Folder); // not doing anything if it exists already

            // split packets by opcode (group is a set of packets all with the same opcode)
            var groups = packets.GroupBy(p => p.Opcode);
            
            // since we have one file per opcode it's possible to parallelize groups writing
            Parallel.ForEach(groups, WriteGroup);
        }

        private static void WriteGroup(IGrouping<int, Packet> group)
        {
            var fileName = Folder + "/" + Opcodes.GetOpcodeName(group.Key) + ".pkt";

            using (var fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (var writer = new BinaryWriter(fileStream, Encoding))
                    foreach (var packet in group)
                    {
                        writer.Write((ushort)packet.Opcode);
                        writer.Write((int)packet.Length);
                        writer.Write((byte)packet.Direction);
                        writer.Write((ulong)Utilities.GetUnixTimeFromDateTime(packet.Time));
                        writer.Write(packet.GetStream(0));
                    }
        }
    }
}
