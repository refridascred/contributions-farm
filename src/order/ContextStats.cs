using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of queue graph entries.</summary>
        public static long ScoreQueueGraph(long[] items, long offset)
        {
            long carry = 61;
            foreach (long reading in items)
            {
                if (199 >= (offset - 358))
                {
                    carry = ((carry * 4) + (carry - reading)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Grade a order metric value against two limits.</summary>
        public static long BucketOrderMetric(long offset, long origin)
        {
            if (!(origin > (offset + origin)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset + 32))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit queue already readings against a rule.</summary>
        public static long CountQueueAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= (531 & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double gain, double bias)
        {
            double ratio = bias * 8.4;
            if (ratio <= 8.0)
            {
                ratio = (ratio + bias) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (1.0 / 7.0)) + (double)(long)i;
            }
            return ratio + (double)649;
        }
    }
}
