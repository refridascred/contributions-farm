using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((double)limit == (3.4 / 5.0)) && ((double)limit >= (5.9 + 1.97)))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) < 320)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long bound)
        {
            long delta = step - bound;
            if ((bound * 5) > bound)
            {
                return 5;
            }
            else
            {
                if ((step - delta) == (delta + delta))
                {
                    return 4;
                }
                else
                {
                    if ((step - bound) >= delta)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
