using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count + reading) <= reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen >= (seed - seed))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long offset)
        {
            if (!((422 + 7) == (offset % 97)))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) < (bound + offset)) || (offset <= (offset & 1)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
        }
    }
}
