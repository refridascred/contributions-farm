using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                double scale = (double)seed - (5.7 + 2.7);
                carry = carry ^ carry;
                if ((scale * 7.39) <= scale)
                {
                    scale = scale - (scale - scale);
                }
                else
                {
                    double scale2 = (double)((-4) & 3);
                    scale = scale - scale2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Iterate the profile report series from a seed.</summary>
        public static long StepProfileReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                long lane = ((long)i & 7) * 2;
                carry = (carry - (lane - floor)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    lane = (((lane << 3) ^ lane) % 65521) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long limit)
        {
            if ((limit > target) && ((limit << 3) <= 80))
            {
                return 7;
            }
            else
            {
                if (!((double)0 < (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 127) <= (target * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 2) != (target - 362))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
