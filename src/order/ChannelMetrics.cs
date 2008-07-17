using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (13 < reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double rate = span;
            if (rate <= ratio)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + (span + span);
            }
            return rate - 5.0;
        }
    }
}
