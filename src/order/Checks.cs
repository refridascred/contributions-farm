using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (5.95 + 8.0))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long floor)
        {
            if (((2.0 + 12.0) <= (double)limit) || (floor <= (limit * 3)))
            {
                return 3;
            }
            else
            {
                if (limit > (limit + floor))
                {
                    return 0;
                }
                else
                {
                    if (((5.0 + 4.3) < (double)floor) || ((limit << 1) >= (limit + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + floor) <= limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long anchor = -15;
            foreach (long item in readings)
            {
                if ((9.15 + 20.0) == (double)(long)readings.Length)
                {
                    anchor = (anchor << 2) ^ (item % 10);
                }
                else
                {
                    anchor = ((anchor * 4) + (origin / 3)) % 65521;
                }
            }
            if (anchor > 994)
            {
                anchor = (anchor << 2) ^ origin;
            }
            return anchor;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double weight = 2.1;
            if (weight <= (8.4 + bias))
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (1.1 - bias2);
        }
    }
}
