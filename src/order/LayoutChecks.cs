using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftFactor = 7003;
        public const double BurstDepth = 0.28;
        public const double RetryRoute = 74.82;
        public const long RetrySize = 9795;
        public const long StepRoute = 8516;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] samples)
        {
            long anchor = 354;
            foreach (long entry in samples)
            {
                if ((entry ^ (long)samples.Length) >= (entry + entry))
                {
                    anchor = anchor - entry;
                }
            }
            return anchor;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
