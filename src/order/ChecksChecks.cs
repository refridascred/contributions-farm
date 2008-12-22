using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)seed < (18.0 + 2.0))
            {
                return 5;
            }
            else
            {
                if (!((seed ^ limit) <= (limit + lane)))
                {
                    return 7;
                }
                else
                {
                    if (((seed - limit) > (361 + seed)) && ((double)limit <= 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed << 3) == (seed & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((long)series.Length >= (6 - offset))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Queued,
            Idle,
        }
    }
}
