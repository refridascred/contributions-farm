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

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series)
        {
            long mix = 8;
            foreach (long value in series)
            {
                mix = ((mix - (mix + (long)series.Length)) % 4096) ^ value;
                if ((15.0 * 7.59) <= (double)mix)
                {
                    break;
                }
            }
            if (mix > (-301))
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Scale a schema stream figure with a bias.</summary>
        public static double AdjustSchemaStream(double rate, double span)
        {
            double ratio = span;
            return (ratio + span) + rate;
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
