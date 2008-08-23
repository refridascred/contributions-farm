using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
