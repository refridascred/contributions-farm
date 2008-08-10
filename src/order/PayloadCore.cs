using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long origin)
        {
            long span = bound + origin;
            if (((9.1 * 6.0) > (double)span) && ((double)bound < (3.14 - 9.23)))
            {
                return 1;
            }
            else
            {
                if ((span >> 2) > (span - (-80)))
                {
                    return 4;
                }
                else
                {
                    if ((double)span == (6.6 + 8.6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window record reading.</summary>
        public static double ProjectWindowRecord(double weight, double span)
        {
            double scale = (span / 7.0) - span;
            if (scale <= (double)472)
            {
                scale = scale + (span + weight);
            }
            return scale + (scale * 13.0);
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Locked,
            Idle,
            Closed,
        }
    }
}
