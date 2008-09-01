using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a commits layout pair into a bucket.</summary>
        public static long SortCommitsLayout(long floor, long seed)
        {
            long cur = floor - seed;
            if ((cur & 15) <= (cur + 18))
            {
                return 4;
            }
            else
            {
                if ((double)floor <= (0.49 * 19.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)cur >= 2.56) && ((double)seed < 4.64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 ^ floor) > (floor >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long SeekSchemaCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
