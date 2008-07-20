using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate window stats readings against a bound.</summary>
        public static bool VerifyWindowStatsRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long seed2)
        {
            if (!((18.0 - 11.0) < (double)seed2))
            {
                return 0;
            }
            else
            {
                if (!(seed < (seed + seed2)))
                {
                    return 1;
                }
                else
                {
                    if ((7 << 1) <= seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((14.0 + 0.32) == (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitScore = 6499;
        public const string BaseCommits = "latest-v2";
        public const long MaxWidth = 115;
        public const long WindowCommits = 9892;
        public const double RetryInterval = 49.53;
    }
}
