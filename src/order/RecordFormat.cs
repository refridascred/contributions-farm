using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Locked,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftScore = 82.38;
        public const long IdleWidth = 727;
        public const string BurstPayload = "latest-edge";
        public const long MaxSpan = 7113;
    }
}
