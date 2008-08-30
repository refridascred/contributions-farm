using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits + hits) <= (8 + hits)) || !((hits >> 2) > (item - item)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell > ((-85) >> 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
