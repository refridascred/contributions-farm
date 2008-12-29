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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(tally >= 258) || ((tally * 5) == (tally + value)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
