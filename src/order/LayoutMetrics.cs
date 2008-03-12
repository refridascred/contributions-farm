using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long floor, long bound)
        {
            if (((bound * 5) >= bound) || ((bound - floor) < 388))
            {
                return 8;
            }
            else
            {
                if (9.0 < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor != (9.72 - 11.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + bound) > (bound - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "staging-edge";
        public const long HardRoute = 5595;
        public const string RetryRoute = "legacy-1";
        public const long BaseRoute = 6156;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if ((10 + origin) == (origin * 2))
            {
                return 7;
            }
            else
            {
                if (((6.61 / 4.0) > (double)floor) && ((origin % 16) == (origin << 1)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
