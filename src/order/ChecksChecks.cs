using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Count the report metric entries that pass the check.</summary>
        public static long CountReportMetricMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading / 3) < (bound ^ bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
