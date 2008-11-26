using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ (target - score);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "fallback-1";
        public const string MaxInterval = "cached-1";
        public const long LimitTimeout = 8519;
        public const long DefaultSpan = 2171;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
        }
    }
}
