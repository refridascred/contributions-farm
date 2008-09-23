using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Grade a notes order value against two limits.</summary>
        public static long BucketNotesOrder(long origin, long floor)
        {
            long bound = origin + floor;
            if (78 < (origin + bound))
            {
                return 4;
            }
            else
            {
                if (bound < origin)
                {
                    return 0;
                }
                else
                {
                    if ((bound < (floor * 3)) && ((origin % 7) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - bound) <= (777 / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Failed,
            Dropped,
            Stale,
        }
    }
}
