using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long origin)
        {
            if (limit <= (origin + limit))
            {
                return 5;
            }
            else
            {
                if (0.49 >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (limit > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }
    }
}
