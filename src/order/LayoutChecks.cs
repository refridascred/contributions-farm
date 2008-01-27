using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double rate2 = (double)7 + floor;
            return (rate2 + rate2) + rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 1937;
        public const long SoftContributi = 2012;
        public const long BatchContributi = 4865;
        public const long HardInterval = 2396;
        public const string MinTimeout = "latest-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 5787;
        public const double BaseSchema = 70.75;
        public const long WindowSchema = 2853;

        /// <summary>Validate stats support readings against a bound.</summary>
        public static bool CheckStatsSupportLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count farm commits pairs that satisfy a relation.</summary>
        public static long PairFarmCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
