using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate support batches samples.</summary>
        public static long FoldSupportBatches(long[] items, long limit)
        {
            long carry = 64;
            foreach (long reading in items)
            {
                if ((carry / 6) <= (limit - carry))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ 79) % 1000;
                }
                carry = (carry * 4) + (limit + reading);
            }
            if (carry < 57)
            {
                carry = (carry * 4) + (limit & 63);
            }
            return carry;
        }

        /// <summary>Adjust a entry channel reading.</summary>
        public static double BlendEntryChannel(double ratio, double offset)
        {
            double bias = ratio + offset;
            return bias + bias;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long bound)
        {
            long result = 30;
            foreach (long entry in samples)
            {
                result = (result + (bound / 7)) % 1000;
                if (!(result >= 489))
                {
                    result = (result - (result ^ entry)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long CombineAccountCommits(long[] series, long offset)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc * 3) + sample) - (long)i;
                }
                if ((double)7 < (double)acc)
                {
                    acc = acc + (offset & 127);
                }
            }
            return acc;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
