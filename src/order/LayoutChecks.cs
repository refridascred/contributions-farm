using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long target, long floor)
        {
            if ((floor ^ target) >= (floor - (-2)))
            {
                return 6;
            }
            else
            {
                if ((target / 8) < (6 / 9))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (5.0 * 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowSize = "open-v2";
        public const double BaseBatch = 7.08;
        public const long LimitWidth = 2514;
        public const long HardScore = 6784;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Active,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Check that every window context entry stays within the limit.</summary>
        public static bool CheckWindowContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)bound != (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
