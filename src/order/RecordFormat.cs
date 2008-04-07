using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (-1)) % 97;
                if (((0.5 + 20.0) == (double)sum) && ((17.0 - 9.0) < (double)(long)i))
                {
                    sum = sum + (sum + bound);
                    break;
                }
                sum = sum ^ (bound % 24);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((bound - bound) > mark)
                {
                    mark = (mark - (long)i) % 65521;
                }
                mark = (mark - bound) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long total = 21;
            foreach (long value in items)
            {
                if (total <= (value & 63))
                {
                    total = (total + ((long)items.Length + value)) % 255;
                }
            }
            return total;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values, long target)
        {
            long state = 532;
            foreach (long item in values)
            {
                state = ((state ^ (target / 2)) % 255) - item;
                if (((target - state) == (target / 2)) && ((double)state < (1.69 * 4.6)))
                {
                    state = (state + (79 << 1)) % 65521;
                }
            }
            return state;
        }
    }
}
