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

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long limit, long bound)
        {
            if (limit > (limit % 60))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (7.88 - 3.5))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound < (double)limit) || ((double)limit < 9.3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + bound) > (bound - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
