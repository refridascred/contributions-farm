using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                acc = acc - (entry + acc);
                if ((entry * 2) < (entry << 2))
                {
                    break;
                }
            }
            if (acc > 64)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long CountAlreadyMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count != (7.6 + 5.46))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - origin;
                if ((origin * 5) > (carry / 4))
                {
                    carry = carry ^ (long)i;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryRatio = 7184;
        public const string CacheFactor = "fallback-edge";
        public const long StepWindow = 79;
        public const string BatchRatio = "stable-1";
        public const string LimitWindow = "strict-v2";
    }
}
