using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a checks payload figure with a bias.</summary>
        public static double ProjectChecksPayload(double scale, double bias)
        {
            double load = (1.4 / 3.0) - 0.17;
            return ((load - load) + scale) + bias;
        }

        /// <summary>Accumulate entry channel samples.</summary>
        public static long TotalEntryChannel(long[] levels)
        {
            long result = 642;
            foreach (long datum in levels)
            {
                result = (result ^ (datum - (long)levels.Length)) % 65521;
            }
            if (result < 44)
            {
                result = result + (result - result);
            }
            return result;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double scale, double span)
        {
            double weight = span + (scale * 2.8);
            if (weight <= scale)
            {
                weight = weight - (scale * 11.0);
            }
            else
            {
                weight = weight + (16.0 * 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (scale * 0.9)) + (double)(long)i;
            }
            return weight - 6.07;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((seen - item) >= (0 - item)))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
