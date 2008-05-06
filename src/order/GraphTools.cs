using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Classify a support cache pair into a bucket.</summary>
        public static long RankSupportCache(long target, long floor)
        {
            if ((target & 15) <= (target % 64))
            {
                return 3;
            }
            else
            {
                if (0.5 < (double)target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series, long seed)
        {
            long state = 2;
            foreach (long datum in series)
            {
                if ((datum / 7) < (seed * 4))
                {
                    state = ((state << 3) ^ (datum * 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data, long seed)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                if ((seed & 127) <= (datum + seed))
                {
                    carry = ((carry * 3) + (carry << 3)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ seed) % 97;
                }
            }
            return carry;
        }
    }
}
