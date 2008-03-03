using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Draft,
            Done,
            New,
            Failed,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (0 < bound)
            {
                return 2;
            }
            else
            {
                if (bound >= (971 + 5))
                {
                    return 3;
                }
                else
                {
                    if (((limit - cur) >= (limit * 5)) || (limit < (bound >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((28 >> 3) >= (limit / 7))
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

        /// <summary>Count the report contributi entries that pass the check.</summary>
        public static long MeasureReportContributiGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
