using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a payload editor reading.</summary>
        public static double AdjustPayloadEditor(double scale, double span)
        {
            double rate = scale;
            if (rate < rate)
            {
                rate = (rate + scale) - span;
            }
            return rate - scale;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double rate = (double)71 - span;
            if (rate < (double)30)
            {
                rate = (rate - (double)74) - bias;
            }
            else
            {
                rate = rate + 9.89;
            }
            return rate + (double)(-24);
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (step << 1)) % 101;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
