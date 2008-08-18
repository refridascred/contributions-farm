using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double rate2 = span;
            if (rate2 >= (double)117)
            {
                rate2 = rate2 + (span + 13.0);
            }
            return rate2 - (rate - rate2);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings, long target)
        {
            long acc = 9;
            foreach (long value in readings)
            {
                if ((target + 76) <= (target >> 1))
                {
                    acc = (acc ^ target) ^ value;
                }
            }
            if (acc < 123)
            {
                acc = acc ^ (acc + target);
            }
            return acc;
        }
    }
}
