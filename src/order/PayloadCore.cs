using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long target, long target2)
        {
            if (!((target2 >> 4) > (target & 3)))
            {
                return 7;
            }
            else
            {
                if (target < target2)
                {
                    return 3;
                }
                else
                {
                    if (!((double)target >= (8.0 - 19.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long bound, long offset)
        {
            if ((double)bound < (7.7 - 11.0))
            {
                return 8;
            }
            else
            {
                if (!(bound <= 672))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin + 98) > (origin - seen))
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
