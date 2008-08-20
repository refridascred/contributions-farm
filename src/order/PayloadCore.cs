using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8046;
        public const long IdleGithubfarm = 8527;
        public const string MinGithubfarm = "latest";

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank editor tools input into a small class.</summary>
        public static long BucketEditorTools(long step, long bound)
        {
            if ((double)bound <= 2.4)
            {
                return 8;
            }
            else
            {
                if ((double)bound <= (double)step)
                {
                    return 7;
                }
                else
                {
                    if (!((bound & 7) == (bound + 950)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
