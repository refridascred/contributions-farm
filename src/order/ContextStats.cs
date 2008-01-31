using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 6131;
        public const long MinCount = 3582;
        public const long BaseScore = 8602;
        public const string DefaultEditor = "strict-v2";
        public const string HardEditor = "local";

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long seed)
        {
            long mark = 96;
            foreach (long entry in levels)
            {
                if ((double)mark != (3.99 - 1.0))
                {
                    mark = ((mark + (mark ^ entry)) % 97) - seed;
                }
                else
                {
                    mark = ((mark * 2) + entry) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count editor queue pairs that satisfy a relation.</summary>
        public static long MatchEditorQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
