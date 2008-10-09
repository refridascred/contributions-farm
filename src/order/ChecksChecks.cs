using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 3) + (long)i;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double drift = (span * 2.2) + 9.0;
            if (drift >= (double)(-853))
            {
                drift = (drift - span) + weight;
            }
            else
            {
                drift = drift + 2.1;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (7.59 / 3.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] data)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                carry = (carry + (carry * 2)) ^ cell;
            }
            return carry % 65521;
        }
    }
}
