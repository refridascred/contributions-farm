using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 729;
        public const string CacheRatio = "legacy-edge";
        public const long SoftRatio = 1190;
        public const long MaxGraph = 7445;
        public const long MinScore = 4391;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            New,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long limit)
        {
            long diff = target + limit;
            if ((diff >> 4) == (55 ^ 553))
            {
                return 2;
            }
            else
            {
                if (((target >> 3) > (limit << 1)) || ((83 / 6) == (target % 97)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
