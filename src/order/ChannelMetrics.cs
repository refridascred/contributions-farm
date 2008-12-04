using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (4.1 - 5.33))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate - (8.99 - 3.0);
            }
            return rate - (1.0 / 2.0);
        }
    }
}
