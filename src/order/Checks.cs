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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result * 4) + (result + result)) ^ (long)i2;
                    result = result + result;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((5 - cur) < (offset ^ (-29)))
            {
                return 2;
            }
            else
            {
                if ((double)offset != (8.72 + 2.15))
                {
                    return 7;
                }
                else
                {
                    if ((cur / 4) >= (offset - offset))
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
