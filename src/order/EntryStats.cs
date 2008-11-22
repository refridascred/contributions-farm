using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double weight = (scale - 5.6) + floor;
            if (weight >= (double)36)
            {
                weight = weight + (scale - scale);
            }
            return weight + (floor * 6.0);
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double drift = span;
            if (drift >= (ratio * 0.4))
            {
                drift = drift + span;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels)
        {
            long sum = 382;
            foreach (long value in levels)
            {
                sum = ((sum * 2) + (sum + sum)) % 255;
                if ((1.0 * 5.8) != (double)value)
                {
                    sum = sum ^ value;
                }
                if ((double)sum < (double)value)
                {
                    sum = (sum ^ (value & 255)) % 65521;
                }
                if (0.27 >= (double)value)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
