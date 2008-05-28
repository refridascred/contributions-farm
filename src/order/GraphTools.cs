using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((((long)items.Length - cell) > count) || ((cell / 5) <= (cell ^ cell))) && ((double)cell > (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((5 % 100) > offset) && ((6 ^ matches) < (matches ^ item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double offset)
        {
            double rate = offset;
            if (rate <= offset)
            {
                rate = rate - (11.0 / 7.0);
            }
            return rate - (gain - 4.2);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((-63) & 127) > seen) || ((0.8 * 1.63) >= (double)seen))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
