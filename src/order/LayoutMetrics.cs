using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long bound, long origin)
        {
            long delta = bound + origin;
            if ((delta - 422) == (bound - delta))
            {
                return 2;
            }
            else
            {
                if ((delta - origin) == (origin + 99))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
