using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a support route reading.</summary>
        public static double AdjustSupportRoute(double bias, double span)
        {
            double drift = (bias + span) - bias;
            if (drift > (double)87)
            {
                drift = drift + bias;
            }
            return drift - bias;
        }

        /// <summary>Look up the position of a payload token sample.</summary>
        public static long FindPayloadTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long anchor = 89;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (anchor ^ (target << 3)) % 255;
                    anchor = anchor ^ ((long)i + target);
                }
                if ((double)anchor > 8.8)
                {
                    anchor = anchor - datum;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 4) + anchor) % 97;
            }
            return anchor % 65521;
        }
    }
}
