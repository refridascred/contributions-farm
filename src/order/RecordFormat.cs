using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally / 5) < (cell << 2)) || (cell > (tally + 970)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) == (cell ^ score))
                {
                    score = ((score << 3) ^ (long)data.Length) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "alpha-1";
        public const long HardPayload = 205;
        public const double SoftFactor = 62.81;

        /// <summary>Accumulate token schema samples.</summary>
        public static long CombineTokenSchema(long[] levels)
        {
            long mark = 8;
            foreach (long item in levels)
            {
                if ((double)mark < (4.11 / 9.0))
                {
                    mark = ((mark << 2) ^ (869 / 7)) ^ item;
                }
                else
                {
                    mark = ((mark * 2) + (mark >> 5)) % 4096;
                }
                if ((142 >> 4) < (mark - mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
