using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long step)
        {
            if (!((671 / 8) == (step - target)))
            {
                return 5;
            }
            else
            {
                if (target > step)
                {
                    return 3;
                }
                else
                {
                    if (!((8 * 4) > target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + target) >= (step * 4)) && ((double)step > 9.5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            if (origin2 < (origin2 & 3))
            {
                return 2;
            }
            else
            {
                if ((origin - origin2) > (origin2 ^ origin2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 8.15;
        public const long MaxSpan = 8570;
        public const long StepInterval = 7150;
        public const double WindowCount = 48.77;
    }
}
