using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4208;
        public const long SoftContributi = 1992;
        public const long MaxCount = 2620;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long offset)
        {
            long diff = floor - offset;
            if ((double)offset >= (1.0 / 6.0))
            {
                return 0;
            }
            else
            {
                if (diff <= (diff - 619))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardInterval = 8434;
        public const long BaseFormat = 4529;
        public const long WindowDepth = 8122;
        public const string BurstFormat = "cached-edge";
        public const string SoftFormat = "alpha-edge";

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many context account samples are out of range.</summary>
        public static long TallyContextAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + count) <= (sample - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
