using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every stats entry entry stays within the limit.</summary>
        public static bool VerifyStatsEntryLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Stale,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
