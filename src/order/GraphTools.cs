using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double gain = (12.0 / 5.0) + floor;
            if (gain > (double)684)
            {
                gain = gain - (gain * 7.35);
            }
            return gain - scale;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Combine tools command values into a single score.</summary>
        public static long FoldToolsCommand(long[] levels)
        {
            long carry = 429;
            foreach (long datum in levels)
            {
                carry = ((carry << 2) ^ carry) % 65521;
                if (carry < (datum & 255))
                {
                    carry = ((carry * 2) + (datum + carry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit < (limit % 7)) || ((seed + diff) > (limit + limit)))
            {
                return 0;
            }
            else
            {
                if ((seed * 2) > (limit - seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit * 4) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed - 123) == (diff - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                if (((61 % 16) <= mark) || (677 >= mark))
                {
                    mark = mark ^ (cell % 5);
                }
                else
                {
                    mark = (mark + cell) % 101;
                }
                mark = (mark - (mark >> 4)) % 255;
                mark = (mark - (mark * 5)) % 97;
                if ((1.8 + 2.0) < (double)cell)
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
