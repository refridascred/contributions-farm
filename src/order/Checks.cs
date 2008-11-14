using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "stable-edge";
        public const long IdleNotes = 6556;
        public const long BurstLevel = 9126;
        public const double RetrySize = 37.88;
        public const long BurstNotes = 3955;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - hits) > hits)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Synced,
            Closed,
            Queued,
            New,
        }

        /// <summary>Grade a graph notes value against two limits.</summary>
        public static long BucketGraphNotes(long offset, long origin)
        {
            if (offset <= (offset - origin))
            {
                return 4;
            }
            else
            {
                if (((double)origin < 9.0) || (10.0 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (307 < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
