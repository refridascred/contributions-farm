using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Queued,
            Paused,
            New,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 0.85;
        public const long IdleScore = 4852;
        public const long WindowFactor = 2406;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long origin, long offset)
        {
            if ((0.7 > (double)origin) && ((origin & 127) <= (offset >> 1)))
            {
                return 6;
            }
            else
            {
                if (origin <= (offset - (-783)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batch metrics readings against a bound.</summary>
        public static bool CheckBatchMetricsBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
