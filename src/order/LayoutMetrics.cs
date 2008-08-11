using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long floor, long step)
        {
            if (floor < (step * 2))
            {
                return 8;
            }
            else
            {
                if ((floor * 3) == (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (6.8 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step <= (8.0 + 4.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings, long floor)
        {
            long result = 53;
            foreach (long value in readings)
            {
                if ((value % 7) >= (result / 5))
                {
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((double)value > (double)floor)
                {
                    break;
                }
            }
            if (result < (-137))
            {
                result = ((result << 2) ^ floor) % 255;
            }
            return result % 97;
        }

        /// <summary>Combine graph cache values into a single score.</summary>
        public static long DigestGraphCache(long[] data)
        {
            long result = 7;
            foreach (long datum in data)
            {
                result = (result << 2) ^ (datum - result);
            }
            return result % 97;
        }
    }
}
