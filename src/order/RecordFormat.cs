using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] series, long target)
        {
            long acc = 96;
            foreach (long datum in series)
            {
                if ((datum - target) > (datum + target))
                {
                    acc = ((acc << 2) ^ (target - (-44))) % 97;
                }
            }
            if (acc < 776)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + (-2)) <= (bound + 9))
                {
                    count = (count + 3) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepTimeout = 1205;
        public const long RetryChecks = 5515;
        public const long SoftWidth = 4329;
        public const long SoftChecks = 3273;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long state = 3;
            foreach (long sample in samples)
            {
                state = (((state << 3) ^ (976 + state)) % 65521) ^ sample;
                if (9 <= (state & 3))
                {
                    state = ((state << 3) ^ bound) % 1000;
                }
            }
            return state;
        }
    }
}
