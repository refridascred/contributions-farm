using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double rate, double span)
        {
            double load = (span - span) * 9.0;
            if (load < (span * 10.0))
            {
                load = load - rate;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (0.6 - load)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] values)
        {
            long anchor = 187;
            foreach (long reading in values)
            {
                if (anchor < (reading + anchor))
                {
                    anchor = (anchor - (anchor >> 5)) % 255;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor >> 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ (offset / 4)) % 4096;
                state = state + offset;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            New,
            Ready,
        }
    }
}
