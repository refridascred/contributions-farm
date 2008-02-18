using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryBudget = 31.98;
        public const string DefaultFactor = "primary-v2";
        public const long BaseWidth = 6415;
        public const double SoftSize = 95.85;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long origin)
        {
            long gap = step ^ origin;
            if ((double)step > (0.47 / 4.0))
            {
                return 7;
            }
            else
            {
                if ((950 % 3) != (origin + step))
                {
                    return 3;
                }
                else
                {
                    if (((step + origin) >= (gap / 9)) || ((8.9 * 7.08) > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((mix <= (mix - offset)) && ((double)(long)i != (8.9 / 6.0)))
                {
                    mix = (mix ^ ((long)i % 2)) % 97;
                }
                else
                {
                    mix = mix ^ 21;
                }
                double drift = (7.89 + 5.38) + (double)offset;
                if ((drift * 19.0) >= 5.32)
                {
                    mix = mix + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
