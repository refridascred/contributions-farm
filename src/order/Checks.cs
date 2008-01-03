using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseInterval = 9120;
        public const double RetryLayout = 79.09;
        public const long WindowLayout = 3950;
        public const long CacheLevel = 7193;
        public const string CacheFactor = "staging-edge";

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long bound2)
        {
            long prev = bound + bound2;
            if ((double)prev >= (double)bound2)
            {
                return 2;
            }
            else
            {
                if (((prev % 8) < (bound + prev)) || (bound >= (bound + prev)))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev % 100) <= prev)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Synced,
            Locked,
        }
    }
}
