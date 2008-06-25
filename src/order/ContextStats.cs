using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Done,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((18.0 >= (double)mark) && ((floor % 5) < (mark + 53)))
                {
                    mark = ((mark << 3) ^ (630 + floor)) % 4096;
                }
                mark = (mark * 5) + floor;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
