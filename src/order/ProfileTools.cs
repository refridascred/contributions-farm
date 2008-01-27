using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long RankToolsSchema(long offset, long target)
        {
            if (offset > target)
            {
                return 5;
            }
            else
            {
                if (41 < target)
                {
                    return 8;
                }
                else
                {
                    if ((90 % 60) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 5) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the stats githubfarm series from a seed.</summary>
        public static long DeriveStatsGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (step % 100)) % 255;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            New,
            Queued,
            Idle,
        }
    }
}
