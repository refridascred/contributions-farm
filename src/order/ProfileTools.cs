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

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
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

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long result = 40;
            foreach (long cell in series)
            {
                if ((2 << 1) <= (result << 1))
                {
                    result = ((result << 3) ^ result) + cell;
                }
                else
                {
                    result = result + (origin + result);
                }
            }
            return result;
        }
    }
}
