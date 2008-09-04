using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            if (13.0 >= (double)floor2)
            {
                return 8;
            }
            else
            {
                if ((floor - floor2) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] series, long target)
        {
            long acc = 499;
            foreach (long entry in series)
            {
                acc = (((acc * 2) + (85 - entry)) % 255) + target;
            }
            return acc;
        }
    }
}
