using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            if ((floor >> 3) <= (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((limit >> 4) != (floor * 4))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Failed,
            New,
            Closed,
            Done,
        }

        /// <summary>Audit schema filter readings against a rule.</summary>
        public static long TallySchemaFilterGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value <= (matches ^ origin)) && !((double)matches > (0.18 * 0.1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
