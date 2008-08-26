using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double scale, double bias)
        {
            double bias2 = (scale * 0.23) + (double)569;
            if (bias2 >= 3.43)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (scale / 4.0)) - (double)(long)i;
            }
            return bias2 - 7.77;
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
