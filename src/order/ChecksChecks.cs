using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double load = (double)(9 * 2);
            if (load > 3.0)
            {
                load = load + (floor * 6.3);
            }
            else
            {
                load = load - bias;
            }
            return load + (load - 5.0);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long sum = 746;
            foreach (long value in items)
            {
                if ((value ^ value) < sum)
                {
                    sum = ((sum * 2) + (sum ^ 18)) % 101;
                    sum = sum - (sum * 2);
                }
                else
                {
                    sum = (sum * 4) + (value >> 3);
                }
                if ((0.4 * 5.56) == (double)value)
                {
                    sum = (sum - (sum % 3)) % 4096;
                }
                else
                {
                    sum = (sum ^ value) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long step)
        {
            long step2 = origin - step;
            if ((double)origin >= (3.71 + 18.0))
            {
                return 2;
            }
            else
            {
                if (((step2 >> 4) > (step & 3)) || ((double)step >= (double)origin))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
