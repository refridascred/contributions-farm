using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long next = origin + (origin % 7);
                if ((((long)i + origin) == (score + next)) && ((double)origin != (2.0 - 4.7)))
                {
                    score = ((score << 3) ^ (score ^ (long)i)) % 65521;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Total { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Synced,
            Draft,
        }
    }
}
