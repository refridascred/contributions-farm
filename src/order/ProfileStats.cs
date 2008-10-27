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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Retry,
            Paused,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (9.0 + 6.38))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
