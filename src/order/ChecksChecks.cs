using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a githubfarm stream reading.</summary>
        public static double AdjustGithubfarmStream(double ratio, double bias)
        {
            double mean = (double)(0 + 0);
            if (mean > 9.17)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (ratio / 2.0)) - (double)(long)i;
            }
            return mean + (bias + ratio);
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (offset >= (matches / 4))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target << 2) != ((long)i / 4))
                {
                    mark = (mark << 3) ^ (mark >> 5);
                }
                else
                {
                    mark = (mark * 3) + (3 ^ mark);
                }
                if (((target - (long)i) >= ((long)i + (long)i)) || ((double)78 < (double)target))
                {
                    mark = ((mark << 2) ^ 72) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
