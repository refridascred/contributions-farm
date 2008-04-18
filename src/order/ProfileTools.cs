using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a batch commits reading by value.</summary>
        public static long LocateBatchCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 3) ^ (acc & 63);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long sum = 71;
            foreach (long cell in samples)
            {
                sum = (sum - sum) % 4096;
                if ((cell ^ sum) < cell)
                {
                    sum = ((sum * 2) + cell) % 97;
                }
                if (((double)sum < (double)cell) || ((cell + cell) <= cell))
                {
                    break;
                }
            }
            if (sum > 19)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings, long offset)
        {
            long state = -932;
            foreach (long reading in readings)
            {
                state = (((state - 544) % 97) + reading) + offset;
            }
            return state % 97;
        }
    }
}
