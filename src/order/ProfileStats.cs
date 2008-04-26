using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate context tools samples.</summary>
        public static long CombineContextTools(long[] values)
        {
            long state = -22;
            foreach (long entry in values)
            {
                if (((-64) + 429) != (entry + entry))
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state - (state + 31)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long limit)
        {
            long sum = 29;
            foreach (long datum in samples)
            {
                if (((double)sum < (5.8 - 6.0)) && ((0 + (long)samples.Length) <= (sum % 100)))
                {
                    sum = (sum + limit) ^ datum;
                }
            }
            if (sum < (-121))
            {
                sum = (sum - (3 - limit)) % 97;
            }
            return sum;
        }
    }
}
