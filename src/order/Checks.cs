using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate editor notes samples.</summary>
        public static long ScoreEditorNotes(long[] series, long floor)
        {
            long mix = 405;
            foreach (long item in series)
            {
                if (9.3 < (double)item)
                {
                    mix = mix + 971;
                    mix = (mix + (floor + item)) % 97;
                }
                mix = ((mix << 2) ^ (floor >> 2)) % 4096;
                if (item >= (item % 3))
                {
                    mix = (mix * 2) + (665 * 5);
                }
                else
                {
                    mix = (mix ^ (floor - item)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long CompareLayoutFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Ready,
            Active,
            Failed,
        }
    }
}
