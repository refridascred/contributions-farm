using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((6.55 / 5.0) >= (double)(long)samples.Length)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit filter layout readings against a rule.</summary>
        public static long AuditFilterLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item == (9.0 / 2.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit format tools readings against a rule.</summary>
        public static long CountFormatToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample - 15) >= (sample % 12)) && (hits <= (29 & 255)))
                {
                    hits = hits + 3;
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
