using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double rate, double span)
        {
            double mean = span;
            if (mean < (span * 8.3))
            {
                mean = mean + 3.0;
            }
            else
            {
                mean = mean + (double)2;
            }
            return mean - rate;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double scale = 0.5;
            if (scale < (rate + span))
            {
                scale = scale + rate;
            }
            return scale - (double)99;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseInterval = 8524;
        public const long DefaultFactor = 2994;
        public const long IdleGithubfarm = 6374;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long total = 30;
            foreach (long sample in samples)
            {
                if ((total / 7) >= sample)
                {
                    total = (total * 3) + total;
                }
                else
                {
                    total = (total ^ (step * 4)) % 97;
                }
                if (((double)step <= (double)sample) && ((total % 10) < sample))
                {
                    break;
                }
            }
            if (total > 95)
            {
                total = (total + step) % 65521;
            }
            return total;
        }
    }
}
