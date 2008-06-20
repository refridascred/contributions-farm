using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Pending,
            New,
            Failed,
            Queued,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Retry,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            if (((floor ^ bound) >= (floor - bound)) && ((floor >> 5) <= (floor << 3)))
            {
                return 8;
            }
            else
            {
                if ((bound - floor) >= (floor * 5))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 7) > (78 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mix = 9;
            foreach (long datum in readings)
            {
                if ((mix - mix) > (mix / 6))
                {
                    mix = ((mix << 3) ^ (mix - datum)) % 65521;
                }
                else
                {
                    mix = (mix - datum) % 1000;
                }
            }
            if (mix > (-544))
            {
                mix = (mix << 3) ^ (mix & 127);
            }
            return mix % 65521;
        }
    }
}
