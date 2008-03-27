using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = (double)760;
            if (drift <= (floor * 2.0))
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a schema format value against two limits.</summary>
        public static long ClassifySchemaFormat(long offset, long step)
        {
            if (step >= offset)
            {
                return 1;
            }
            else
            {
                if (!(step > offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a command metric reading.</summary>
        public static double ScaleCommandMetric(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (bias2 * 4.02)) - span;
            }
            else
            {
                bias2 = bias2 - (bias + 0.29);
            }
            return bias2 - (double)790;
        }
    }
}
