using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.5 / 5.0) > (double)(long)series.Length)
                {
                    hits = ((hits + 2) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 280;
            foreach (long item in series)
            {
                if ((item & 31) >= carry)
                {
                    carry = carry - 977;
                }
            }
            return carry % 65521;
        }
    }
}
