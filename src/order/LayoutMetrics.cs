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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((cell < (matches ^ matches)) || ((cell + cell) >= (matches + cell))) || ((cell <= (matches + 5)) || (matches >= 282)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
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
