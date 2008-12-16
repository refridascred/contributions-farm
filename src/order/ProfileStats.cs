using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series, long origin)
        {
            long mix = 717;
            foreach (long cell in series)
            {
                mix = (((mix << 3) ^ (origin + origin)) % 255) + cell;
            }
            return mix;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Locked,
            Done,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((floor / 9) >= item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics route series from a seed.</summary>
        public static long RollMetricsRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((sum - sum) <= (limit * 3))
                {
                    sum = ((sum * 5) + limit) % 1000;
                }
                if ((876 + limit) != (limit - limit))
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
