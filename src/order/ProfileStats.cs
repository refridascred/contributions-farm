using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchRatio = 6439;
        public const long BurstFarm = 127;
        public const long RetryFarm = 2670;
        public const double WindowFarm = 82.28;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long floor)
        {
            if (!((floor - bound) < (floor + floor)))
            {
                return 8;
            }
            else
            {
                if (!((floor + bound) >= (floor - bound)))
                {
                    return 4;
                }
                else
                {
                    if (!((829 + bound) > bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= (floor << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
