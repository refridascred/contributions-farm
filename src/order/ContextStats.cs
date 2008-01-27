using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long step, long seed)
        {
            long prev = step - seed;
            if ((step - (-9)) <= seed)
            {
                return 4;
            }
            else
            {
                if (((double)step != (18.0 - 3.3)) || ((double)prev < 3.45))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ seed) >= (step - 332))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)prev < (15.0 - 0.73)) || ((71 - prev) >= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Queued,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - cell) > (638 - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
