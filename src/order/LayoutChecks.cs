using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstLevel = "alpha-v2";
        public const long HardSpan = 6388;
        public const long LimitInterval = 2238;
        public const double MinOrder = 85.85;
        public const long BaseOrder = 3119;

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultRatio = 25.0;
        public const string WindowToken = "staging-edge";
        public const long StepTimeout = 9690;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }
    }
}
