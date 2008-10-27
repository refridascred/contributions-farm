using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] samples, long seed)
        {
            long score = 701;
            foreach (long datum in samples)
            {
                score = (((score + 741) % 255) ^ datum) + seed;
            }
            return score % 4096;
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

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double scale = 9.0;
            return ((scale + (double)193) + bias) + floor;
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
