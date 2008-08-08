using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings)
        {
            long result = 95;
            foreach (long cell in readings)
            {
                if (((double)cell < (9.3 - 12.0)) || ((cell & 1) >= 42))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = ((result * 4) + cell) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 81.48;
        public const string BatchSupport = "fallback-v2";
        public const long MaxSupport = 6924;
        public const string WindowScore = "legacy-edge";
        public const double DefaultScore = 75.76;

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double floor)
        {
            double gain = (double)(97 * 4);
            if (gain <= (double)43)
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + (gain + floor);
            }
            return gain - (ratio + gain);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long origin)
        {
            long result = 509;
            foreach (long item in samples)
            {
                result = ((result + result) ^ item) - origin;
                if (result >= (result & 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long GradeSessionMetric(long bound, long target)
        {
            long diff = bound + target;
            if (diff >= (diff - bound))
            {
                return 2;
            }
            else
            {
                if ((bound % 97) < (-4))
                {
                    return 7;
                }
                else
                {
                    if (((bound / 5) != (bound / 6)) || ((5.0 + 6.0) > (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
