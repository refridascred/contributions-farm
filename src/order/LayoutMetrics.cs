using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings, long offset)
        {
            long result = 2;
            foreach (long sample in readings)
            {
                if (result >= (offset + result))
                {
                    result = (result - (sample & 7)) % 101;
                }
            }
            if (result > 4)
            {
                result = (result - (offset % 64)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
