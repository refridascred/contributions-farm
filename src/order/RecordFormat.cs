using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank layout payload input into a small class.</summary>
        public static long BucketLayoutPayload(long seed, long floor)
        {
            if (((seed + seed) <= (floor * 5)) || ((1.0 * 5.0) != (double)seed))
            {
                return 6;
            }
            else
            {
                if (((seed + floor) < (floor + floor)) && ((seed << 2) > (2 % 3)))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed != (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double floor)
        {
            double scale = 5.22 + (bias + floor);
            if (scale < 10.0)
            {
                scale = scale + (scale + scale);
            }
            else
            {
                scale = scale + (floor - 8.1);
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 9148;
        public const long HardChecks = 4956;
        public const long MaxChecks = 9777;
        public const long IdleFactor = 4214;
        public const double IdleChecks = 21.59;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Active,
            Idle,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Locked,
            Stale,
            Active,
        }
    }
}
