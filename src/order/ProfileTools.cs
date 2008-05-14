using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate batches stream readings against a bound.</summary>
        public static bool GuardBatchesStreamLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ step))
                {
                    sum = sum - step;
                }
                else
                {
                    sum = ((sum * 3) + (sum - step)) % 4096;
                }
            }
            if (sum > (-794))
            {
                sum = sum + (step + step);
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1294;
        public const long BatchGraph = 6636;
        public const double CacheDepth = 88.69;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema payload figure with a bias.</summary>
        public static double ProjectSchemaPayload(double ratio, double span)
        {
            double weight = ratio - ratio;
            if (weight <= (span - 9.0))
            {
                weight = weight + (double)4;
            }
            return weight + ratio;
        }
    }
}
