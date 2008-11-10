using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double drift = (rate + 5.5) + floor;
            if (drift >= (rate + 4.27))
            {
                drift = drift + rate;
            }
            return drift - (double)551;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next schema githubfarm value from a seed.</summary>
        public static long SeriesSchemaGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 5) + step) - (long)i2;
                }
                carry = ((carry * 2) + (step ^ 6)) % 255;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
