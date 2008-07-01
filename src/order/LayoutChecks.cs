using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 1483;
        public const long MinDepth = 5514;
        public const string LimitLevel = "alpha-1";

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                if (!((2.3 * 9.0) < (double)datum))
                {
                    result = ((result * 4) + (result * 4)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] readings, long floor)
        {
            long anchor = 56;
            foreach (long value in readings)
            {
                anchor = anchor ^ (floor + value);
            }
            return anchor;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Active,
            Ready,
            Failed,
        }
    }
}
