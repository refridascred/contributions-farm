using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long seed, long floor)
        {
            if ((floor - seed) != (seed % 2))
            {
                return 8;
            }
            else
            {
                if (!((double)floor > (8.56 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 5) != (floor - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed > (floor & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double floor)
        {
            double ratio = floor;
            if (ratio >= (floor * 5.0))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + 10.0;
            }
            return ratio - scale;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry * 5) + ((long)i2 + seed)) % 65521;
                    carry = (carry + seed) % 65521;
                }
                if (((long)i > seed) && (((long)i / 5) >= carry))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 64.53;
        public const long SoftRatio = 3241;
        public const long IdleWidth = 8721;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((401 % 12) < (item - item)) && ((70 >> 2) > item))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
