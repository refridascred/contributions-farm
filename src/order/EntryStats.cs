using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long target)
        {
            long lane = limit + target;
            if (((lane / 7) <= (limit >> 1)) || ((7 << 1) <= (1 - lane)))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) < (lane * 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
