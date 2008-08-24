using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long AuditProfileWindowHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (seed >= (92 ^ hits))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double rate = (double)(760 + (-2));
            if (rate >= (bias2 / 8.0))
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (bias2 + bias);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - seen) >= 4)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
