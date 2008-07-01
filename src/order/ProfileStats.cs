using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool ValidateLayoutFarmBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
