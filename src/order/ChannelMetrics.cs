using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long bound)
        {
            if ((bound << 2) <= bound)
            {
                return 6;
            }
            else
            {
                if (((bound + 6) < (bound * 5)) && ((seed & 63) >= (bound / 9)))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (9.7 + 7.15)) || ((double)seed != (6.4 / 4.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + seed) < (seed + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 670;
        public const long MaxEntry = 3330;
        public const long CacheCount = 7448;
    }
}
