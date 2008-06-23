using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Retry,
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                long gap = (bound / 4) % 3;
                if (8.0 > (double)(long)i)
                {
                    mix = ((mix * 4) + (bound * 3)) % 1000;
                    gap = (gap + (573 - (long)i)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (gap & 31)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long seed)
        {
            long delta = step + seed;
            if ((6.7 + 3.6) == (double)delta)
            {
                return 3;
            }
            else
            {
                if (((delta - step) >= (seed % 2)) && ((step + delta) == (step & 127)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target - 40) != (target ^ total))
                {
                    total = (total + total) % 65521;
                    break;
                }
                else
                {
                    total = (total - (target * 5)) % 97;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
