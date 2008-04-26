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

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
