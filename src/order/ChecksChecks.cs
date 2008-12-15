using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
