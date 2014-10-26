using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V6_0_2_19033
{
    public static class Opcodes_6_0_2
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ACCEPT_TRADE, 0x1C85},
            {Opcode.CMSG_ADDON_REGISTERED_PREFIXES, 0x07CC | 0x10000},
            {Opcode.CMSG_AUCTION_HELLO, 0x1074},
            {Opcode.CMSG_AUTH_SESSION, 0x1B05},
            {Opcode.CMSG_CAST_SPELL, 0x0D55},
            {Opcode.CMSG_CREATURE_QUERY, 0x14D6},
            {Opcode.CMSG_DB_QUERY_BULK, 0x09AC},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x0D97},
            {Opcode.CMSG_GARRISON_MISSION_BONUS_ROLL, 0x14C6},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x1143},
            {Opcode.CMSG_GUILD_BANK_BUY_TAB, 0x1238},
            {Opcode.CMSG_GUILD_QUERY, 0x00E4},
            {Opcode.CMSG_GUILD_QUERY_RANKS, 0x018E},
            {Opcode.CMSG_LIST_INVENTORY, 0x1037},
            {Opcode.CMSG_LOAD_SCREEN, 0x09B8},
            {Opcode.CMSG_CANCEL_TRADE, 0x07DA},
            {Opcode.CMSG_LOG_DISCONNECT, 0x1856},
            {Opcode.CMSG_ITEM_REFUND_INFO, 0x0154},
            {Opcode.CMSG_JOIN_CHANNEL, 0x0EC3},
            {Opcode.CMSG_MESSAGECHAT_AFK, 0x0EEF},
            {Opcode.CMSG_MESSAGECHAT_DND, 0x12C7 | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_CHANNEL, 0x0288},
            {Opcode.CMSG_MESSAGECHAT_EMOTE, 0x12D4 | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x039B | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_PARTY, 0x06EF},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x07B3 | 0x10000},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x1288 | 0x10000},
            {Opcode.CMSG_MOVE_HEARTBEAT, 0x0E36},
            {Opcode.CMSG_MOVE_TIME_SKIPPED, 0x0F46},
            {Opcode.CMSG_NAME_QUERY, 0x0BA4},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x0CC3},
            {Opcode.CMSG_PAGE_TEXT_QUERY, 0x0B98},
            {Opcode.CMSG_PING, 0x1B75},
            {Opcode.CMSG_PET_NAME_QUERY, 0x05A7},
            {Opcode.CMSG_PLAYER_LOGIN, 0x03A8},
            {Opcode.CMSG_QUEST_NPC_QUERY, 0x02A7},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x0A90},
            {Opcode.CMSG_QUEST_QUERY, 0x0A94},
            {Opcode.CMSG_QUESTGIVER_QUERY_QUEST, 0x0358},
            {Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST, 0x1243},
            {Opcode.CMSG_REDIRECT_AUTH_PROOF, 0x1806},
            {Opcode.CMSG_RESET_FACTION_CHEAT, 0x1876},
            {Opcode.CMSG_SET_SELECTION, 0x1038},
            {Opcode.CMSG_GOSSIP_HELLO, 0x0647},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x0CC4},
            {Opcode.SMSG_SHOW_BANK, 0x0204},
            {Opcode.CMSG_SET_RAID_DIFFICULTY, 0x1A76},
            {Opcode.CMSG_TIME_SYNC_RESP, 0x0A02},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x00D4},
            {Opcode.CMSG_WARDEN_DATA, 0x00F3},

            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x11AC},
            {Opcode.SMSG_ACTION_BUTTONS, 0x03F4},
            {Opcode.SMSG_ADDON_INFO, 0x1400},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_ACCOUNT, 0x1603},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA_PLAYER, 0x01A4},
            {Opcode.SMSG_AUCTION_COMMAND_RESULT, 0x1554},
            {Opcode.SMSG_AUCTION_HELLO, 0x0417},
            {Opcode.SMSG_AUCTION_LIST_RESULT, 0x13B4},
            {Opcode.SMSG_AURA_UPDATE, 0x128B},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x10AA},
            {Opcode.SMSG_AUTH_RESPONSE, 0x0564},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x1428},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x0C4D},
            {Opcode.SMSG_CHANNEL_NOTIFY_JOINED, 0x1C0A},
            {Opcode.SMSG_CHAR_CREATE, 0x0637},
            {Opcode.SMSG_CHAR_DELETE, 0x12A4},
            {Opcode.SMSG_CHAR_ENUM, 0x1154},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x10EF | 0x20000},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x0203},
            {Opcode.SMSG_CRITERIA_UPDATE_ACCOUNT, 0x0727},
            {Opcode.SMSG_CRITERIA_UPDATE_PLAYER, 0x0AEC},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x11C0},
            {Opcode.SMSG_DB_REPLY, 0x1574},
            {Opcode.SMSG_EMOTE, 0x03F8},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x01E7},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x0177},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS_GLUE_SCREEN, 0x0577},
            {Opcode.SMSG_FORCE_SEND_QUEUED_PACKETS, 0x128A},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x08E3},
            {Opcode.SMSG_GOSSIP_COMPLETE, 0x0292},
            {Opcode.SMSG_GOSSIP_POI, 0x08E8},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x01EE},
            {Opcode.SMSG_GUILD_MOTD, 0x125A},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x034A},
            {Opcode.SMSG_GUILD_RANK, 0x035A},
            {Opcode.SMSG_GUILD_ROSTER, 0x0779},
            {Opcode.SMSG_HOTFIX_INFO, 0x0AA8},
            {Opcode.SMSG_INIT_CURRENCY, 0x00A4},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x0BB7},
            {Opcode.SMSG_INITIAL_SPELLS, 0x0297},
            {Opcode.SMSG_LIST_INVENTORY, 0x0103},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x01BB},
            {Opcode.SMSG_LEARNED_SPELL, 0x02D8},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x00EF},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x09B3},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x0528},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x1044},
            {Opcode.SMSG_SEND_MAIL_RESULT, 0x0035},
            {Opcode.SMSG_MESSAGECHAT, 0x0E09},
            {Opcode.SMSG_MOTD, 0x0E5D},
            {Opcode.SMSG_MONSTER_MOVE, 0x04A4},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x1667},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x0BE8},
            {Opcode.SMSG_PAGE_TEXT_QUERY_RESPONSE, 0x1163},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x03B4},
            {Opcode.SMSG_PLAYER_MOVE, 0x019C},
            {Opcode.SMSG_PONG, 0x1881},
            {Opcode.SMSG_QUERY_TIME_RESPONSE, 0x0224},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x03DE},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x00D5},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x1082},
            {Opcode.SMSG_SEND_SERVER_LOCATION, 0x1257},
            {Opcode.SMSG_ARENA_SEASON_WORLD_STATE, 0x0618},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x07B3 | 0x20000},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x12D4 | 0x20000},
            {Opcode.SMSG_SET_PHASE_SHIFT, 0x0567},
            {Opcode.SMSG_SET_PROFICIENCY, 0x12AF},
            {Opcode.SMSG_SET_VIGNETTE, 0x1613},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x07A7},
            {Opcode.SMSG_SPELL_GO, 0x1288 | 0x20000},
            {Opcode.SMSG_SPELL_START, 0x0FCB},
            {Opcode.SMSG_SUSPEND_COMMS, 0x1882},
            {Opcode.SMSG_TALENTS_INFO, 0x10FF},
            {Opcode.SMSG_TRAINER_LIST, 0x0678},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x0CA8},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0617},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x07DB},
            {Opcode.SMSG_UPDATE_OBJECT, 0x03EF},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x1368},
            {Opcode.SMSG_VOID_STORAGE_CONTENTS, 0x0137},
            {Opcode.SMSG_WARDEN_DATA, 0x12EF},
            {Opcode.SMSG_WEATHER, 0x01BF},
            {Opcode.SMSG_WHO, 0x080A},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x1164},
        };
    }
}
