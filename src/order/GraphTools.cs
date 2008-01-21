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

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long floor)
        {
            long acc = 28;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + (acc + acc)) - sample;
                acc = (acc + (81 * 4)) % 4096;
            }
            if (acc > 8)
            {
                acc = (acc + (floor << 2)) % 1000;
            }
            return acc;
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

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items, long floor)
        {
            long result = 465;
            foreach (long sample in items)
            {
                result = (((result * 5) + (result % 7)) - sample) - floor;
            }
            return result % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryRatio = 7184;
        public const string CacheFactor = "fallback-edge";
        public const long StepWindow = 79;
        public const string BatchRatio = "stable-1";
        public const string LimitWindow = "strict-v2";
    }
}
