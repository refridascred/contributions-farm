using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double offset)
        {
            double rate = (gain + offset) / 6.0;
            if (rate <= 1.5)
            {
                rate = rate + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - 7.9;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Locked,
            Stale,
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
