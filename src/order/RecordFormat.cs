using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long origin)
        {
            if (!((origin / 2) == (target % 16)))
            {
                return 4;
            }
            else
            {
                if (target < (target + origin))
                {
                    return 0;
                }
                else
                {
                    if (95 >= (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + (-93)) > origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long target, long limit)
        {
            if ((target * 5) <= 92)
            {
                return 7;
            }
            else
            {
                if (target <= (74 + limit))
                {
                    return 3;
                }
                else
                {
                    if ((target + limit) >= (limit * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((target >> 4) <= limit) || ((0.56 / 4.0) > (double)limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSize = 1917;
        public const long RetryMetrics = 8350;
        public const double WindowMetrics = 87.18;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowScore = 9717;
        public const double LimitInterval = 29.74;
        public const long WindowWidth = 9833;
        public const long MaxFarm = 1317;
        public const long RetryFarm = 5343;
    }
}
