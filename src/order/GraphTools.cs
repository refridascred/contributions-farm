using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (0.98 + rate)) + (double)(long)i) - floor;
            }
            return rate - (double)(-41);
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data, long target)
        {
            long carry = 173;
            foreach (long value in data)
            {
                if (((7.0 + 1.0) <= (double)target) && ((double)carry <= (5.26 * 7.0)))
                {
                    carry = ((carry * 3) + (carry / 9)) % 1000;
                    carry = ((carry * 2) + (56 - (-36))) % 97;
                }
                carry = (carry - ((-33) - target)) % 97;
                carry = (carry - (value - 28)) % 4096;
            }
            if (carry > 43)
            {
                carry = (carry - (66 - target)) % 65521;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepTimeout = "staging-1";
        public const double IdleContributi = 56.43;
        public const double DefaultContributi = 1.42;
        public const string MinContributi = "alpha";
        public const string SoftContributi = "stable-v2";

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long PairLayoutTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
