using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (0.2 + offset)) - (double)(long)i) - scale;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mix = -630;
            foreach (long item in levels)
            {
                mix = (mix ^ (mix + mix)) ^ item;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(((16.0 + 1.0) <= (double)datum) && ((matches >> 1) <= (matches + 58))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((260 / 8) > tally) && (tally <= (tally + tally)))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
