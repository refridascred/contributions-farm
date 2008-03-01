using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset > 5) || (((long)i % 2) > mark))
                {
                    mark = (mark - (offset + mark)) % 65521;
                }
                if (offset < (offset + mark))
                {
                    mark = (mark << 2) ^ (mark & 63);
                    continue;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long limit)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                total = (total - entry) % 1000;
            }
            if (total < 99)
            {
                total = ((total << 2) ^ (limit << 2)) % 255;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Queued,
            Closed,
            Idle,
        }
    }
}
