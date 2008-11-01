using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long sum = 0;
            foreach (long entry in levels)
            {
                sum = ((sum - 1) % 255) - entry;
                sum = (sum - (sum << 1)) % 1000;
                if ((double)sum != (3.4 + 11.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine tools stream values into a single score.</summary>
        public static long TotalToolsStream(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                sum = (sum + (sum - 125)) % 4096;
                if (((-842) >> 4) < value)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double load = bias2 + bias2;
            if (load < 6.0)
            {
                load = load - (bias * 2.0);
            }
            return load - bias;
        }
    }
}
