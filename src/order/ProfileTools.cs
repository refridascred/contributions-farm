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

        /// <summary>Adjust a session payload reading.</summary>
        public static double BlendSessionPayload(double weight, double offset)
        {
            double bias = (double)(308 / 7);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + 4.74) - (double)(long)i) + offset;
            }
            return bias + (weight - weight);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 6549;
        public const long IdleContributi = 3206;
        public const string LimitTimeout = "fallback-v2";
        public const string CacheWidth = "standard-1";

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
