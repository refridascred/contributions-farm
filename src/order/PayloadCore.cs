using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length >= (177 - cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
