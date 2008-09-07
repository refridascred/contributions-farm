using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] items)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                if ((anchor - reading) < (reading / 4))
                {
                    anchor = (anchor + (-47)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor / 5)) % 65521;
                }
                if ((reading < (anchor - anchor)) || (35 >= (anchor + anchor)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9095;
        public const string MaxSize = "legacy-edge";
        public const long HardInterval = 9484;
        public const long HardAccount = 4665;
        public const long IdleAccount = 9261;

        /// <summary>Count the record profile entries that pass the check.</summary>
        public static long TallyRecordProfileHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - sample) >= seed)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
