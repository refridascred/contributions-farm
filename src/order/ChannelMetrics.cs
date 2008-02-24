using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double mean = floor;
            if (mean <= mean)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - 2.9;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain * 5.04)) + (double)(long)i;
            }
            return mean + (floor + floor);
        }

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long AuditCacheNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches > (0.9 + 4.78))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
