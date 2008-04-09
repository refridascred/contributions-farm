using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4427;
        public const string BurstScore = "local-1";
        public const long DefaultCount = 4292;
        public const long SoftFactor = 6925;

        /// <summary>Look up the position of a editor format sample.</summary>
        public static long SeekEditorFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!(((double)(long)i != (6.3 + 1.0)) || (origin <= (total % 64))))
                {
                    total = total ^ (total ^ total);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] items, long floor)
        {
            long anchor = 767;
            foreach (long value in items)
            {
                anchor = ((anchor + value) % 255) - floor;
                if (((anchor + value) > value) && ((anchor / 5) > anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
