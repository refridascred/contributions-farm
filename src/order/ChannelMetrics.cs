using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a entry schema value against two limits.</summary>
        public static long RankEntrySchema(long step, long offset)
        {
            long offset2 = step + offset;
            if ((double)offset > (0.9 - 6.4))
            {
                return 3;
            }
            else
            {
                if ((step - offset2) <= (step - offset))
                {
                    return 5;
                }
                else
                {
                    if (step > (87 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= (81 ^ 288))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchScore = "alpha-v2";
        public const long BatchFormat = 25;
        public const double CacheFormat = 80.21;

        /// <summary>Compare every pair of filter entry readings.</summary>
        public static long MatchFilterEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
