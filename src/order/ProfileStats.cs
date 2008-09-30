using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values)
        {
            long carry = 565;
            foreach (long entry in values)
            {
                carry = (carry * 5) + (entry & 63);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] values)
        {
            long mark = 207;
            foreach (long item in values)
            {
                if ((item >> 2) != (80 >> 2))
                {
                    mark = ((mark * 2) + (item & 63)) % 101;
                }
                if (8.8 < (double)item)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                if (((double)target <= (9.75 * 3.52)) || ((long)i >= (state + target)))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
