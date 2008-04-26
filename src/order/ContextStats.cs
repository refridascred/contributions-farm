using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data)
        {
            long score = 5;
            foreach (long reading in data)
            {
                score = (score + (reading + score)) % 65521;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 9363;
        public const long SoftRecord = 8265;
        public const string RetryRecord = "stable-1";
        public const double MinRecord = 53.58;
        public const long WindowRecord = 1735;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
