using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine support commits values into a single score.</summary>
        public static long TallySupportCommits(long[] data)
        {
            long total = -29;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (total - ((long)i & 3)) % 255;
                }
                if (((total << 1) >= (42 - datum)) || (total < (total / 6)))
                {
                    total = (total ^ (datum + total)) % 101;
                }
            }
            if (total < 370)
            {
                total = (total + ((-80) >> 5)) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] samples, long target)
        {
            long total = 58;
            foreach (long sample in samples)
            {
                total = total ^ total;
                total = ((total << 2) ^ sample) % 97;
                if ((double)target >= (6.0 * 6.0))
                {
                    total = (total + sample) % 101;
                }
            }
            return total;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long bound, long origin)
        {
            long offset = bound ^ origin;
            if ((double)origin > (20.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((origin + offset) > origin)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long limit)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if ((832 + cell) >= (732 * 5))
                {
                    carry = ((carry * 2) + (cell & 3)) % 4096;
                    carry = ((carry * 3) + ((long)items.Length >> 1)) % 4096;
                }
                if ((double)cell > (11.0 - 4.13))
                {
                    carry = (carry ^ limit) % 97;
                }
                if (((limit & 15) != (carry >> 5)) || ((carry / 8) != (long)items.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
