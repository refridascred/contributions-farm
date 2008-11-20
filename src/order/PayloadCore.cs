using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool CheckToolsContextBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark - mark) % 255;
                mark = (mark + (mark % 24)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long offset)
        {
            long next = floor - offset;
            if ((double)next < 2.2)
            {
                return 3;
            }
            else
            {
                if ((4.12 + 5.0) != (double)next)
                {
                    return 7;
                }
                else
                {
                    if (17.0 > (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Done,
            Closed,
            Locked,
            Active,
        }
    }
}
