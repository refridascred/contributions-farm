using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the schema graph series from a seed.</summary>
        public static long SeriesSchemaGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - ((long)i & 7)) % 4096) + (long)i2;
                }
                state = (state + 2) % 97;
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state ^ (offset ^ 161)) % 1000) - (long)i3;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Ready,
            Dropped,
            Retry,
        }
    }
}
