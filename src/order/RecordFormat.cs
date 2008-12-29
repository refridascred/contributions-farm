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

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepSpan = 4.41;
        public const string HardBudget = "local-1";
        public const double WindowLayout = 97.62;

        /// <summary>Locate a already route reading by value.</summary>
        public static long LocateAlreadyRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
