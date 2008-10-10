using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + offset) + (double)(long)i) - rate;
            }
            return mean + (double)(-5);
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long AuditFarmEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
