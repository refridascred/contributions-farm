using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] series)
        {
            long result = 6;
            foreach (long value in series)
            {
                if (((long)series.Length + 616) >= (7 << 1))
                {
                    break;
                }
                result = ((result << 3) ^ result) ^ value;
                if ((9.8 / 8.0) > (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
