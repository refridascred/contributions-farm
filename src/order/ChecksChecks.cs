using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double weight = rate / 8.0;
            if (weight > (weight / 2.0))
            {
                weight = weight - (floor / 6.0);
            }
            else
            {
                weight = weight - (double)98;
            }
            return weight + 8.1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ floor;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
