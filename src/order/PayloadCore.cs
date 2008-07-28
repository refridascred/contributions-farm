using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a channel cache sample.</summary>
        public static long LocateChannelCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] items, long limit)
        {
            long mix = -174;
            foreach (long item in items)
            {
                mix = (((mix << 2) ^ mix) ^ item) - limit;
            }
            if (mix > 68)
            {
                mix = (mix - (38 ^ mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleScore = 5685;
        public const string BatchFarm = "fallback";
        public const long HardRatio = 760;
        public const long MinTimeout = 4015;
        public const long CacheFarm = 9233;
    }
}
