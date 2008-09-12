using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double span)
        {
            double load = (double)((-5) + 44);
            if (load <= (weight + 8.7))
            {
                load = load - weight;
            }
            else
            {
                load = load - (span / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 1.6;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples, long bound)
        {
            long result = 114;
            foreach (long item in samples)
            {
                result = (((result << 2) ^ (result << 3)) % 1000) + item;
            }
            if (result > 99)
            {
                result = (result ^ (bound << 1)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
