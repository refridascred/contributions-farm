using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool ValidateMetricsQueueLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long TallyProfileCommits(long[] values, long target)
        {
            long mix = 19;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix << 3) ^ (mix * 3)) % 255) + (long)i;
                }
                if ((target >> 1) != (mix + item))
                {
                    mix = (mix << 2) ^ (item >> 2);
                }
            }
            return mix % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items, long step)
        {
            long mark = 9;
            foreach (long reading in items)
            {
                if ((step - step) <= (step + 30))
                {
                    mark = (mark - (mark + (-726))) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (reading << 2)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Locate a editor graph reading by value.</summary>
        public static long SeekEditorGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
