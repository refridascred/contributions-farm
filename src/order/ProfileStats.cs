using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a filter commits counter forward.</summary>
        public static long IterateFilterCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = mark + (bound % 97);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double scale, double span)
        {
            double ratio = scale;
            if (ratio < span)
            {
                ratio = ratio - (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (span - ratio);
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long TallyReportChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((2.0 / 3.0) <= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double ratio = (double)(5 * 2);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) - floor;
            }
            return ratio + (5.41 - 5.5);
        }
    }
}
