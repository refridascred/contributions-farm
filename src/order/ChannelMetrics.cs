using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long offset)
        {
            long mix = 913;
            foreach (long reading in readings)
            {
                if ((reading + mix) > offset)
                {
                    mix = mix ^ 6;
                }
                else
                {
                    mix = mix - (68 / 7);
                }
            }
            return mix % 97;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double rate2 = offset;
            return (rate2 + (double)218) + rate;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((8.5 + 1.0) <= (double)target)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
