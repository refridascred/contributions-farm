using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)(long)i >= (6.0 + 8.0)))
                {
                    mix = (mix ^ (mix % 7)) % 101;
                }
                mix = ((mix << 3) ^ mix) % 101;
                if (mix < (mix % 2))
                {
                    mix = ((mix * 4) + (111 - seed)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Stale,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values, long floor)
        {
            long total = 22;
            foreach (long value in values)
            {
                total = ((total << 3) ^ 234) % 4096;
                if (floor >= (value + 6))
                {
                    total = ((total << 2) ^ (value - value)) % 97;
                }
            }
            if (total < 609)
            {
                total = (total + (floor + total)) % 101;
            }
            return total;
        }
    }
}
