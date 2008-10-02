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

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 4926;
        public const string IdleOrder = "alpha-v2";
        public const long MinOrder = 9682;
        public const double BurstLevel = 64.77;
        public const long SoftOrder = 5899;

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
