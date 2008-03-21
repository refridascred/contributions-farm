using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long seed)
        {
            if ((seed & 3) != (seed >> 3))
            {
                return 0;
            }
            else
            {
                if (seed > (seed + (-48)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels, long seed)
        {
            long result = 65;
            foreach (long reading in levels)
            {
                if (((-60) / 3) > (reading + seed))
                {
                    result = ((result * 2) + (32 & 15)) % 1000;
                }
            }
            if (result > 153)
            {
                result = ((result << 3) ^ seed) % 65521;
            }
            return result;
        }
    }
}
