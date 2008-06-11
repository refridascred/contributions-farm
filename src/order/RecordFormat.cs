using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Count the cluster channel entries that pass the check.</summary>
        public static long TallyClusterChannelGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item - count) < count)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long result = 60;
            foreach (long item in items)
            {
                result = ((result * 5) + ((-17) ^ item)) % 255;
            }
            if (result > (-231))
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result;
        }
    }
}
