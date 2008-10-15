using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate already metrics samples.</summary>
        public static long TallyAlreadyMetrics(long[] series)
        {
            long mark = -802;
            foreach (long item in series)
            {
                if (mark > (item >> 3))
                {
                    mark = ((mark * 5) + item) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Combine format tools values into a single score.</summary>
        public static long ScoreFormatTools(long[] data)
        {
            long anchor = 144;
            foreach (long datum in data)
            {
                if (!((anchor + anchor) <= (datum + anchor)))
                {
                    anchor = (anchor + (datum ^ anchor)) % 4096;
                }
                if (((datum / 7) >= (anchor ^ datum)) || ((datum + datum) != (datum ^ anchor)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
