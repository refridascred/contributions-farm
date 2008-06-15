using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many checks buffer samples are out of range.</summary>
        public static long MeasureChecksBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((hits << 2) == (hits ^ hits)) || ((hits / 2) > (sample + hits))) && ((long)series.Length != (sample / 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Active,
            Synced,
            Locked,
            Retry,
        }
    }
}
