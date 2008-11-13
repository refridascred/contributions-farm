using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of token account entries.</summary>
        public static long TallyTokenAccount(long[] series)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                acc = acc + ((-6) + cell);
            }
            if (acc < 19)
            {
                acc = ((acc * 5) + (acc ^ acc)) % 97;
            }
            return acc;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long seed)
        {
            long next = origin + seed;
            if (seed <= (seed >> 4))
            {
                return 7;
            }
            else
            {
                if (((origin + next) > (seed - origin)) || ((double)origin > (8.6 * 7.64)))
                {
                    return 0;
                }
                else
                {
                    if (seed < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
