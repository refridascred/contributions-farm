using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double span)
        {
            double rate = span;
            if (rate <= (rate / 4.0))
            {
                rate = rate - (span + ratio);
            }
            else
            {
                rate = rate - (ratio + span);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Check that every record token entry stays within the limit.</summary>
        public static bool GuardRecordTokenBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Draft,
            Closed,
            Retry,
            Done,
        }
    }
}
