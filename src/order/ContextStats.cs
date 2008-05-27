using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate commits cache readings against a bound.</summary>
        public static bool GuardCommitsCacheBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Idle,
            Locked,
            Failed,
        }
    }
}
