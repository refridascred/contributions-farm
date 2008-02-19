using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Idle,
            Locked,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long score = 307;
            foreach (long cell in items)
            {
                score = ((score + (long)items.Length) ^ cell) + origin;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading >= (hits % 10)) && ((double)step < (6.54 + 6.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double span)
        {
            double drift = weight - span;
            return drift - (weight / 3.0);
        }
    }
}
