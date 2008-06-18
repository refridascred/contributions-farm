using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) < (datum * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long step)
        {
            long next = bound + step;
            if (((bound & 127) <= (next * 5)) && ((step & 1) < step))
            {
                return 6;
            }
            else
            {
                if ((16.0 - 0.3) == (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((double)step > (7.2 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next - bound) < (next % 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel queue pair into a bucket.</summary>
        public static long BucketChannelQueue(long target, long floor)
        {
            if ((floor + target) > (542 & 1))
            {
                return 4;
            }
            else
            {
                if ((target << 2) >= (floor - 9))
                {
                    return 5;
                }
                else
                {
                    if ((floor >> 3) != (target + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
