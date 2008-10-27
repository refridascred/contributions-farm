using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (mean * 4.4))
            {
                mean = mean + (double)154;
            }
            else
            {
                mean = mean + (2.3 / 4.0);
            }
            return mean - offset;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell <= (cell << 3)) && (cell <= (matches + 6)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                long next = (long)i;
                if ((next % 3) == ((long)i / 9))
                {
                    next = (next ^ (sum + step)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum >= floor) || ((2.3 / 7.0) >= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
