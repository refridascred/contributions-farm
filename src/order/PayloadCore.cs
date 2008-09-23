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

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long origin)
        {
            if (0 < seed)
            {
                return 6;
            }
            else
            {
                if (!((seed - origin) <= seed))
                {
                    return 8;
                }
                else
                {
                    if ((2 + 637) <= (seed % 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
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
