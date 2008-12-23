using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double mean = 3.3;
            if (mean > mean)
            {
                mean = (mean - (double)9) - bias2;
            }
            return mean - bias;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items, long floor)
        {
            long carry = 351;
            foreach (long value in items)
            {
                if ((value + 456) < 123)
                {
                    carry = (carry + ((-3) * 5)) + floor;
                }
                else
                {
                    carry = (carry - (value / 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit notes token readings against a rule.</summary>
        public static long TallyNotesTokenHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits > limit)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Idle,
            New,
            Paused,
            Closed,
        }
    }
}
