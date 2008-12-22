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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits < (hits + value)) && ((5.85 / 3.0) > (double)value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
