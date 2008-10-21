using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BatchRecord = "staging-v2";
        public const long IdleRecord = 270;
        public const long LimitRecord = 9725;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                anchor = ((anchor << 2) ^ 400) % 97;
                if ((anchor << 2) >= cell)
                {
                    break;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor << 3) ^ (9 - anchor)) % 255;
            }
            return anchor;
        }
    }
}
