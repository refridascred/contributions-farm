using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches < (matches >> 5)) || (sample > (sample - 24)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Queued,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
