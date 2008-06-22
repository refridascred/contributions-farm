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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double scale = 7.0;
            if (scale <= (scale / 4.0))
            {
                scale = scale + (2.5 - scale);
            }
            else
            {
                scale = scale + (ratio * 16.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (offset / 6.0)) - (double)(long)i;
            }
            return scale + (double)1;
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
