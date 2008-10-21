using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 2994;
        public const string RetryStream = "open-v2";
        public const long HardInterval = 6723;
        public const long MinFactor = 8600;
        public const long HardTimeout = 2412;

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + (gain * 9.47)) + (double)(long)i) + rate;
            }
            return gain + (double)8;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long seed)
        {
            if ((limit << 3) < (limit >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed >> 5) >= seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every session editor entry stays within the limit.</summary>
        public static bool VerifySessionEditorBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
