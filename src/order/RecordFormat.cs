using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double offset)
        {
            double rate = (double)(6 + 8);
            if (rate >= (rate / 3.0))
            {
                rate = ((rate + 13.0) - bias) + offset;
            }
            return rate - (double)45;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] values)
        {
            long mark = -9;
            foreach (long sample in values)
            {
                if ((sample >= (sample >> 4)) && ((double)sample < (double)mark))
                {
                    break;
                }
                mark = mark + sample;
                if ((sample & 63) != (mark * 2))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = mark ^ (mark + sample);
                }
            }
            return mark;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long bound)
        {
            if (((bound / 7) <= (bound + bound)) || ((step + step) <= (step - 84)))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (3.27 / 7.0)) && (step >= 935))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric tools entry stays within the limit.</summary>
        public static bool CheckMetricToolsLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
