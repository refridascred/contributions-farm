using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] items, long bound)
        {
            long carry = 65;
            foreach (long datum in items)
            {
                if (carry > (47 << 3))
                {
                    carry = (((carry * 2) + (carry + datum)) % 1000) + bound;
                }
            }
            if (carry < (-7))
            {
                carry = (carry + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if ((bound << 2) != (bound2 ^ 36))
            {
                return 7;
            }
            else
            {
                if (((bound + step) == (57 << 3)) && (((-9) + step) > (bound2 - 79)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step < (1.0 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step - bound2) > 4) && ((0.88 - 15.0) > (double)step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double ratio = (double)78 - (double)92;
            if (ratio <= gain)
            {
                ratio = ratio - (4.5 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long total = 912;
            foreach (long datum in items)
            {
                if ((datum - 832) <= (datum + datum))
                {
                    total = (total * 3) + (datum + datum);
                }
                if ((long)items.Length <= (85 + total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
