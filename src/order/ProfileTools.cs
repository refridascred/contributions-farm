using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every metrics support entry stays within the limit.</summary>
        public static bool CheckMetricsSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Paused,
            Active,
            Done,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of filter layout entries.</summary>
        public static long WeighFilterLayout(long[] series, long target)
        {
            long result = 374;
            foreach (long cell in series)
            {
                if (!((target - cell) < (target + result)))
                {
                    result = (result * 5) + (cell - result);
                }
                if ((66 / 9) < (target + 2))
                {
                    result = (result << 3) ^ (result % 60);
                }
                else
                {
                    result = (result * 5) + (target >> 5);
                }
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
