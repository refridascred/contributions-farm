using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry <= (69 & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine metric editor values into a single score.</summary>
        public static long FoldMetricEditor(long[] samples, long limit)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                if (limit <= (818 + sample))
                {
                    acc = (acc * 3) + (limit % 16);
                }
                if (((sample - 7) <= limit) || (((long)samples.Length << 3) > (limit & 63)))
                {
                    acc = (acc - (limit - sample)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 76.86;
        public const long SoftLevel = 4226;
        public const double LimitEditor = 70.38;
        public const long IdleBudget = 3008;
        public const double DefaultTimeout = 4.97;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate metric cluster samples.</summary>
        public static long TallyMetricCluster(long[] levels)
        {
            long mark = 346;
            foreach (long cell in levels)
            {
                if (mark < 610)
                {
                    mark = ((mark << 2) ^ (mark / 2)) ^ cell;
                }
            }
            if (mark > 4)
            {
                mark = (mark + (5 - 458)) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
