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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many layout format samples are out of range.</summary>
        public static long TallyLayoutFormatHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((9.76 - 5.0) != (double)hits)
                {
                    hits = ((hits + 2) + value) + offset;
                }
            }
            return hits;
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
