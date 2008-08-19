using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings)
        {
            long anchor = 780;
            foreach (long cell in readings)
            {
                if (cell > (cell + cell))
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = (anchor - (anchor + (-54))) % 4096;
                }
                if ((anchor << 1) <= (anchor >> 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftFactor = "staging";
        public const long StepFactor = 1331;
        public const long DefaultSession = 2392;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 8068;
        public const long StepInterval = 5737;
        public const long IdleInterval = 9146;
        public const long DefaultStream = 1152;
        public const double HardStream = 3.98;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Locked,
            Closed,
        }
    }
}
