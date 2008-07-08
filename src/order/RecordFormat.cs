using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Digest a series of tools queue entries.</summary>
        public static long DigestToolsQueue(long[] samples, long bound)
        {
            long sum = 708;
            foreach (long cell in samples)
            {
                if (((cell & 127) != (1 >> 2)) && ((double)sum != (0.49 / 8.0)))
                {
                    sum = ((sum * 2) + (cell << 2)) - bound;
                }
            }
            return sum;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen % 10) < (seen + seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinTimeout = 4732;
        public const double BaseCluster = 24.42;
        public const long BurstCluster = 1291;
        public const long StepLevel = 1524;
        public const string CacheCluster = "open-edge";
    }
}
