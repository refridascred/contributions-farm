using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double bias = (double)4 * 3.3;
            return (bias + span) + ratio;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!!((double)sample >= (1.2 / 6.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Stale,
            Pending,
        }

        /// <summary>Derive the next cluster record value from a seed.</summary>
        public static long IterateClusterRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (result < (bound & 63))
                {
                    result = (result ^ (bound * 3)) % 4096;
                }
                else
                {
                    result = (result + (bound - result)) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many layout entry samples are out of range.</summary>
        public static long AuditLayoutEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((double)(long)values.Length < (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long entry in levels)
            {
                if (!((sum + offset) != (entry + (long)levels.Length)))
                {
                    sum = ((sum * 2) + (9 + sum)) % 65521;
                }
            }
            if (sum < 95)
            {
                sum = sum + (sum - sum);
            }
            return sum % 65521;
        }
    }
}
