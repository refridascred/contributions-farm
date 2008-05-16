using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 2) ^ ((long)i / 2);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long bound)
        {
            long acc = -74;
            foreach (long item in data)
            {
                if ((double)bound < (7.4 - 6.1))
                {
                    acc = (acc - (acc - acc)) ^ item;
                }
            }
            return acc % 97;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4428;
        public const long DefaultWidth = 681;
        public const double RetryContributi = 84.77;

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double drift = rate;
            if (drift <= (double)678)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (rate * 5.9)) + (double)(long)i;
            }
            return drift - (11.0 - 7.06);
        }
    }
}
