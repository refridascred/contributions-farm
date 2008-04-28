using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((bound / 2) > (entry % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data)
        {
            long anchor = 91;
            foreach (long item in data)
            {
                anchor = (anchor + (item % 64)) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long step)
        {
            if (((9 / 6) >= target) && ((step ^ 62) >= (221 + target)))
            {
                return 0;
            }
            else
            {
                if (!((step << 3) != (step - target)))
                {
                    return 6;
                }
                else
                {
                    if ((6 + target) == (target % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
