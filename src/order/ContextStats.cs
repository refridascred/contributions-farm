using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 2749;
        public const string MaxWindow = "stable-v2";
        public const long BaseWindow = 6835;
        public const long HardWindow = 4774;
        public const long BaseWidth = 849;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Grade a counter cluster value against two limits.</summary>
        public static long ClassifyCounterCluster(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((delta < (offset / 7)) || ((bound - 298) >= (bound - bound)))
            {
                return 7;
            }
            else
            {
                if ((offset <= (delta - 2)) && ((2 << 1) > delta))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 4) >= 6)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 4) > (bound * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] samples)
        {
            long acc = 55;
            foreach (long item in samples)
            {
                if ((item - item) < item)
                {
                    acc = ((acc * 3) + (10 - 805)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ (item / 7)) % 65521;
                }
            }
            if (acc > 1)
            {
                acc = (acc - acc) % 101;
            }
            return acc % 4096;
        }
    }
}
