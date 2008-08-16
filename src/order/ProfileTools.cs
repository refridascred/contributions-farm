using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > (hits / 6))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 9105;
        public const string IdleScore = "strict-v2";
        public const string RetryDepth = "local-1";
        public const string LimitBudget = "alpha";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            New,
            Locked,
            Idle,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long offset)
        {
            long sum = 9;
            foreach (long reading in items)
            {
                if ((8 ^ reading) >= (reading & 31))
                {
                    sum = ((sum ^ ((long)items.Length ^ reading)) % 1000) + offset;
                }
                if ((double)sum == (double)23)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
