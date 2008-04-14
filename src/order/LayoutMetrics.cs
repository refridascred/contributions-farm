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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = mix ^ (454 ^ 658);
                if (mix >= (limit - mix))
                {
                    mix = ((mix << 2) ^ (mix / 6)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
