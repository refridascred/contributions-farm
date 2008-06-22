using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long floor)
        {
            if ((178 % 2) != ((-870) + bound))
            {
                return 6;
            }
            else
            {
                if (9 > (floor >> 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double span)
        {
            double rate = gain;
            if (rate > span)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - 7.0;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long offset)
        {
            long mix = 672;
            foreach (long value in levels)
            {
                if ((value << 1) >= 652)
                {
                    mix = (mix - (mix / 6)) + offset;
                }
            }
            return mix % 1000;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double rate = (double)(96 + 1);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - ratio) - (double)(long)i) - bias;
            }
            return rate + ratio;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
