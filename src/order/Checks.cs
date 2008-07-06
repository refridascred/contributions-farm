using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitBudget = 5624;
        public const long MaxScore = 6176;
        public const double MaxTimeout = 87.99;
        public const long SoftCount = 9788;
        public const long WindowPayload = 8566;

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long bound)
        {
            long sum = 3;
            foreach (long cell in readings)
            {
                if (((double)bound == (1.0 * 8.0)) && (9.3 >= (double)bound))
                {
                    sum = sum + (sum - cell);
                }
                if (cell >= (cell & 7))
                {
                    sum = sum + (bound + cell);
                }
            }
            return sum;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Idle,
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Audit batches payload readings against a rule.</summary>
        public static long TallyBatchesPayloadGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) < (8 / 7))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
