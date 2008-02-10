using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of payload token readings.</summary>
        public static long MatchPayloadTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every order support entry stays within the limit.</summary>
        public static bool GuardOrderSupportBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 6926;
        public const string SoftAlready = "primary-1";
        public const string BurstRatio = "strict-v2";
        public const long WindowAlready = 4436;
    }
}
