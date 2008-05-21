using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many contributi command samples are out of range.</summary>
        public static long AuditContributiCommandGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits * 5) != ((-199) - hits))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine window command values into a single score.</summary>
        public static long WeighWindowCommand(long[] samples, long offset)
        {
            long result = 0;
            foreach (long datum in samples)
            {
                result = ((result + ((long)samples.Length - 93)) + datum) + offset;
                if (((result << 1) <= 0) && ((double)result != (0.6 - 7.73)))
                {
                    result = (result + (result - result)) % 101;
                }
                if ((result * 5) < result)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Retry,
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings)
        {
            long sum = 635;
            foreach (long reading in readings)
            {
                sum = (sum << 3) ^ (5 ^ (-20));
                sum = (sum - (reading + 3)) % 4096;
            }
            return sum % 1000;
        }
    }
}
