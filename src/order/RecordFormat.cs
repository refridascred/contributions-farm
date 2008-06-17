using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((limit2 & 31) == (limit - 729))
            {
                return 6;
            }
            else
            {
                if (((edge * 4) == (78 - (-263))) || ((limit + limit2) > (edge - limit2)))
                {
                    return 5;
                }
                else
                {
                    if (!(9.52 < (double)limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.3 - 16.0) == (double)limit)
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

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= (floor * 1.0))
            {
                mean = mean - 2.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (8.79 * 2.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum >= (datum % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] data, long target)
        {
            long carry = 605;
            foreach (long datum in data)
            {
                carry = ((carry * 5) + carry) % 65521;
                if ((datum + datum) != (carry << 3))
                {
                    carry = carry + (954 ^ target);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + target)) % 1000;
                }
            }
            if (carry > 414)
            {
                carry = (carry << 3) ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long LookupCounterBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
