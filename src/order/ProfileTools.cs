using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 38.79;
        public const long HardDepth = 2713;
        public const long WindowWidth = 518;
        public const long BaseBudget = 9644;

        /// <summary>Fold a list of already metrics readings.</summary>
        public static long ScoreAlreadyMetrics(long[] series, long limit)
        {
            long total = 1;
            foreach (long sample in series)
            {
                if (total >= (31 + total))
                {
                    total = ((total * 4) + (586 << 2)) % 65521;
                }
                if ((limit * 2) < (sample - sample))
                {
                    total = (total ^ (limit - 3)) % 1000;
                }
            }
            if (total > 9)
            {
                total = total + (2 ^ limit);
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 6261;
        public const long DefaultContributi = 9407;
        public const double CacheContributi = 82.73;
        public const long BurstContributi = 1260;
    }
}
