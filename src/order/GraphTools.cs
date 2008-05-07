using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)anchor != (14.0 * 0.2)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor << 2) ^ (floor + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
