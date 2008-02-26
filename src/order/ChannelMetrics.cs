using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Grade a farm graph value against two limits.</summary>
        public static long SortFarmGraph(long floor, long floor2)
        {
            if ((5.0 * 13.0) < (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((floor >> 2) >= floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor2) < 622)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((origin % 10) < (origin * 5)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
