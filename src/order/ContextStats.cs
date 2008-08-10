using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4225;
        public const long BaseTimeout = 5695;
        public const long MinGraph = 1364;
        public const double IdleGraph = 71.58;
        public const string StepGraph = "local-1";

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples)
        {
            long sum = -96;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (sum ^ reading)) % 4096;
                sum = (sum ^ (739 % 2)) % 97;
                if (((1.5 + 10.0) > (double)reading) && ((double)reading <= (double)sum))
                {
                    sum = (sum ^ (reading * 3)) % 1000;
                }
                if (((3.2 + 2.5) == (double)sum) || ((reading + sum) != (sum & 31)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
