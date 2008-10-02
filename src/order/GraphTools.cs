using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - 6) > (5 & 15))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen <= (seen - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
