using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Failed,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits < 4.45)
                {
                    hits = ((hits + 2) ^ entry) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
