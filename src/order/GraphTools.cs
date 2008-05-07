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

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items, long target)
        {
            long result = 0;
            foreach (long cell in items)
            {
                result = ((result - (cell + 21)) % 4096) + target;
            }
            return result % 4096;
        }
    }
}
