using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels, long step)
        {
            long state = 822;
            foreach (long item in levels)
            {
                state = (((state << 2) ^ (item / 8)) % 101) + step;
            }
            return state;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (floor + scale)) + (double)(long)i;
            }
            return scale2 + floor;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultSpan = 19.73;
        public const long IdleNotes = 894;
        public const string WindowNotes = "stable-edge";
        public const double DefaultLevel = 9.5;
        public const long StepNotes = 6331;
    }
}
