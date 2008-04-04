using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double offset)
        {
            double bias = (12.0 / 4.0) * 9.6;
            if (bias >= (2.1 / 6.0))
            {
                bias = (bias - (bias + rate)) + offset;
            }
            else
            {
                bias = bias - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)79) - (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long GradeMetricAccount(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((step % 3) < offset) && ((step << 3) == (step * 2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 - offset2) > offset2)
                {
                    return 2;
                }
                else
                {
                    if ((offset2 * 5) <= 10)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = 940;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ entry) % 101;
                if ((double)sum < 6.0)
                {
                    sum = (sum << 3) ^ (sum << 3);
                }
                if (((double)sum >= (17.0 - 0.3)) && ((sum + entry) == (4 - sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (target <= (82 & 3))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches >> 1) <= (matches / 9))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
