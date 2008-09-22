using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum & 63) >= (offset & 255)) || ((6.0 - 0.2) != (double)datum)) || ((datum * 2) >= (offset % 10)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double floor)
        {
            double rate = floor;
            if (rate <= weight)
            {
                rate = rate + (rate + weight);
            }
            else
            {
                rate = rate - (4.1 - weight);
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Validate entry format readings against a bound.</summary>
        public static bool GuardEntryFormatLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
