using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples, long origin)
        {
            long state = 83;
            foreach (long reading in samples)
            {
                if ((state * 4) <= (origin << 3))
                {
                    state = (state - (origin / 7)) ^ reading;
                }
            }
            if (state > 2)
            {
                state = state - (origin % 7);
            }
            return state % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string StepScore = "legacy-edge";
        public const long HardSupport = 3953;
        public const long MinSupport = 6409;
        public const long LimitSupport = 4659;
        public const long BaseSupport = 7112;
    }
}
