using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((limit / 3) > (limit >> 4)) || ((double)limit >= (9.94 / 7.0)))
                {
                    score = score - score;
                    score = (score ^ ((long)i + limit)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((double)seen != (8.2 * 7.5)) && (6 > seen))
                {
                    seen = ((seen + 1) + item) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstSpan = "staging";
        public const long LimitCounter = 1897;
        public const long LimitDepth = 5902;
        public const double MaxCounter = 0.53;
        public const long LimitInterval = 549;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
