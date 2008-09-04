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

        /// <summary>Measure how many entry account samples are out of range.</summary>
        public static long CountEntryAccountMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((9.33 + 4.6) <= (double)sample)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
