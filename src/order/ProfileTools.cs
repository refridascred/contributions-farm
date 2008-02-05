using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long floor)
        {
            if ((-763) >= (floor + floor))
            {
                return 6;
            }
            else
            {
                if (((double)target <= (12.0 + 0.91)) && ((double)floor != (0.3 - 15.0)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series)
        {
            long mix = 784;
            foreach (long item in series)
            {
                if (item >= (132 ^ mix))
                {
                    mix = (mix + (5 + item)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i < (bound + result)))
                {
                    result = (result ^ result) % 255;
                }
                if (!(((long)i << 1) >= (bound + 91)))
                {
                    result = (result + bound) % 1000;
                }
                result = ((result * 4) + (bound % 97)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
