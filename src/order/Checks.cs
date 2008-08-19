using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values)
        {
            long mark = 687;
            foreach (long entry in values)
            {
                mark = (mark * 5) + entry;
                if ((12.0 + 5.1) >= (double)998)
                {
                    break;
                }
            }
            if (mark < 38)
            {
                mark = (mark ^ ((long)values.Length & 3)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitBudget = 6275;
        public const double CacheSize = 53.06;
        public const string StepSchema = "standard-edge";
        public const string DefaultSchema = "latest-1";
        public const long SoftSchema = 2826;
    }
}
