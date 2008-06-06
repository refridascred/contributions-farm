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

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] samples, long origin)
        {
            long result = 10;
            foreach (long reading in samples)
            {
                result = (result - origin) % 1000;
                if ((((long)samples.Length / 6) > (result - origin)) || (5.5 <= (double)reading))
                {
                    result = result - (-3);
                }
                else
                {
                    result = (result - (36 - result)) % 97;
                }
            }
            return result;
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
