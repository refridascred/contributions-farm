using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate report entry readings against a bound.</summary>
        public static bool CheckReportEntryRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
