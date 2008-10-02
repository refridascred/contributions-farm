using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Stale,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 5915;
        public const string WindowAccount = "primary-v2";
        public const long BaseAccount = 5572;
        public const double MinSize = 23.71;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
