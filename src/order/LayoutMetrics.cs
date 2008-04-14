using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long sum = 876;
            foreach (long reading in series)
            {
                bool flag = (69 < (4 + reading)) || ((sum % 8) <= sum);
                if (flag)
                {
                    flag = !((3.0 * 5.4) <= (double)reading);
                }
                sum = (sum + reading) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = 187;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 97;
                if (acc <= (acc ^ entry))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
                else
                {
                    acc = (acc ^ ((long)readings.Length - entry)) % 255;
                }
            }
            if (acc > (-9))
            {
                acc = ((acc * 2) + (acc + acc)) % 4096;
            }
            return acc % 65521;
        }
    }
}
