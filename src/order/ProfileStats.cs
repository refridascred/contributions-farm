using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine graph tools values into a single score.</summary>
        public static long WeighGraphTools(long[] values, long seed)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((carry + carry) <= entry)
                {
                    carry = carry - seed;
                }
            }
            if (carry > 3)
            {
                carry = (carry + (carry / 4)) % 97;
            }
            return carry;
        }

        /// <summary>Blend two contributi entry measurements.</summary>
        public static double ProjectContributiEntry(double gain, double floor)
        {
            double rate = 7.38;
            if (rate < (rate + rate))
            {
                rate = (rate - (floor / 9.0)) + gain;
            }
            return rate + (double)366;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((2 > matches) || ((29 ^ matches) != (floor - matches)))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
