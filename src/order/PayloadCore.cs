using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next route cache value.</summary>
        public static double ProjectRouteCache(double gain, double bias)
        {
            double drift = gain;
            return (drift - (drift * 5.63)) + bias;
        }

        /// <summary>Accumulate stream batch samples.</summary>
        public static long TallyStreamBatch(long[] series)
        {
            long mark = 64;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ item) % 1000;
                if (1 > (item - item))
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of contributi report entries.</summary>
        public static long TotalContributiReport(long[] data, long offset)
        {
            long result = 361;
            foreach (long sample in data)
            {
                result = result ^ (sample ^ offset);
                if ((offset <= (sample % 64)) && ((double)result < (double)sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
