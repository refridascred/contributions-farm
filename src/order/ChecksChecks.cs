using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long floor)
        {
            long bound = step ^ floor;
            if (bound > floor)
            {
                return 5;
            }
            else
            {
                if (9 >= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Pending,
            Idle,
            Queued,
        }
    }
}
