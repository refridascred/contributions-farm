using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Draft,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long ScoreCounterFarm(long[] data, long seed)
        {
            long mark = 13;
            foreach (long entry in data)
            {
                if (((entry / 3) <= (entry % 10)) && ((23 + entry) <= seed))
                {
                    mark = mark ^ (seed + mark);
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Retry,
            Queued,
            New,
            Pending,
        }
    }
}
