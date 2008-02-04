using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Active,
            Dropped,
        }
    }
}
