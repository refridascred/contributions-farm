using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((4.0 - 7.14) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
