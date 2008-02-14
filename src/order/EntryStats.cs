using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Region { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Stale,
            Paused,
        }

        /// <summary>Measure how many commits account samples are out of range.</summary>
        public static long CountCommitsAccountHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((565 >> 4) <= (cell / 6)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 9970;
        public const long DefaultSpan = 8594;
        public const string MaxSchema = "primary";
        public const long StepSchema = 2337;
        public const string SoftSchema = "cached-v2";

        /// <summary>Blend two batch contributi measurements.</summary>
        public static double SmoothBatchContributi(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)344) + (double)(long)i) + floor;
            }
            return ratio - (bias * 6.48);
        }
    }
}
