using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Queued,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits <= (hits - hits))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= rate)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (double)122) + (double)(long)i;
            }
            return rate2 + rate;
        }
    }
}
