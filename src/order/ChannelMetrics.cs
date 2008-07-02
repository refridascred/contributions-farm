using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            New,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 3841;
        public const string MaxStats = "latest-v2";
        public const long MinTimeout = 3715;
        public const long StepStats = 1060;
        public const string MinFactor = "primary";

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
