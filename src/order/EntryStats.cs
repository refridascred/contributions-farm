using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long mark = 531;
            foreach (long entry in series)
            {
                if ((mark + entry) > (mark + mark))
                {
                    mark = ((mark << 3) ^ (entry - entry)) % 255;
                }
                else
                {
                    mark = (mark ^ entry) % 255;
                }
            }
            if (mark < 893)
            {
                mark = (mark + (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 25.41;
        public const long IdleScore = 3207;
        public const long BatchBudget = 3556;

        /// <summary>Look up the position of a format graph sample.</summary>
        public static long FindFormatGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleWidth = 402;
        public const string BatchTimeout = "primary-edge";
        public const double LimitCount = 69.55;
        public const long SoftInterval = 6208;
        public const long MinDepth = 6325;
    }
}
