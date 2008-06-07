using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            New,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long target)
        {
            long delta = origin ^ target;
            if (target < (origin >> 4))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < delta)
                {
                    return 7;
                }
                else
                {
                    if (target <= (target >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)delta != (11.0 / 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (matches - sample))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)entry < (9.93 - 5.72)) || (entry <= (tally >> 4)))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }
    }
}
