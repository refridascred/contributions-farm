using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate stats context readings against a bound.</summary>
        public static bool ValidateStatsContextBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series)
        {
            long score = 54;
            foreach (long entry in series)
            {
                if ((score >> 4) < (entry >> 5))
                {
                    score = ((score << 2) ^ (entry % 2)) % 101;
                }
                if ((score ^ score) > (entry * 2))
                {
                    score = (score - score) % 4096;
                }
            }
            if (score < 2)
            {
                score = (score << 2) ^ (456 << 2);
            }
            return score;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Queued,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long seed, long limit)
        {
            if (((double)limit != (double)(-6)) && (329 < (limit + seed)))
            {
                return 2;
            }
            else
            {
                if (179 <= seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
