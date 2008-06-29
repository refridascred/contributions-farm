using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double gain, double bias)
        {
            double ratio = gain;
            return (ratio + (2.0 + gain)) + bias;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally > 17.0)
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long AuditContributiFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (857 <= (origin + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
