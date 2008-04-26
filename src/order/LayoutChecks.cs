using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] levels, long seed)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                mark = ((mark << 2) ^ (seed + seed)) + cell;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheWidth = 594;
        public const double IdlePayload = 37.26;
        public const double BurstRatio = 17.5;
        public const long HardPayload = 952;
        public const long RetrySpan = 1622;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
