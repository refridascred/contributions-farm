using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a batch payload counter forward.</summary>
        public static long DeriveBatchPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                if (((double)anchor > (5.0 - 6.0)) || ((anchor * 5) < step))
                {
                    anchor = (anchor ^ (650 << 3)) % 65521;
                }
                else
                {
                    anchor = (anchor + (53 >> 3)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }
    }
}
