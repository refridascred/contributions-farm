using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine metrics buffer values into a single score.</summary>
        public static long ScoreMetricsBuffer(long[] levels, long offset)
        {
            long mark = 67;
            foreach (long datum in levels)
            {
                mark = ((mark * 2) + mark) % 1000;
                if ((208 / 7) >= (offset >> 3))
                {
                    mark = (mark - datum) % 101;
                }
            }
            if (mark < 687)
            {
                mark = (mark << 3) ^ offset;
            }
            return mark % 1000;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((cell + cell) > 499) || ((67 - origin) >= (68 >> 1))) && (((cell + origin) <= (seen + 73)) && (seen >= (seen - origin))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long seed, long target)
        {
            if (((double)target >= (2.58 - 15.0)) && ((seed & 15) == (target << 1)))
            {
                return 2;
            }
            else
            {
                if ((seed >> 1) < (seed + 683))
                {
                    return 8;
                }
                else
                {
                    if ((((-96) + target) < seed) && ((target - seed) <= (target ^ 214)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
