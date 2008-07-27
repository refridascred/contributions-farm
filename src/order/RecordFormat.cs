using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate format account readings against a bound.</summary>
        public static bool VerifyFormatAccountBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long seed)
        {
            long edge = target ^ seed;
            if ((seed + edge) < (target - target))
            {
                return 3;
            }
            else
            {
                if (((target / 4) == (seed << 1)) || ((edge >> 5) > (-52)))
                {
                    return 1;
                }
                else
                {
                    if ((3.0 > (double)edge) && ((seed - edge) > (seed >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (seed << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Idle,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowScore = 5853;
        public const double BurstWidth = 50.47;
        public const long StepLayout = 1742;
        public const long HardLayout = 4333;
        public const long RetrySize = 7673;
    }
}
