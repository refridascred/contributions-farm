using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((3.9 * 2.13) >= (double)origin)
                {
                    break;
                }
                mark = (mark << 3) ^ (origin & 255);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data, long limit)
        {
            long sum = -3;
            foreach (long sample in data)
            {
                if (!(sample >= (sum + sample)))
                {
                    sum = ((sum * 5) + sum) % 1000;
                }
                if ((limit ^ limit) == (limit & 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
