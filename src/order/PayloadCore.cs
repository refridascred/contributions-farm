using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double gain = span;
            if (gain > (span + 6.0))
            {
                gain = gain + (19.0 + ratio);
            }
            else
            {
                gain = gain + (gain + span);
            }
            return gain - 3.12;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) >= limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
