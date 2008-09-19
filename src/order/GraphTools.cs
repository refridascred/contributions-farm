using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up metrics payload samples.</summary>
        public static long OverlapMetricsPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 981;
        public const long BaseEntry = 4088;
        public const long MinBudget = 4087;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
