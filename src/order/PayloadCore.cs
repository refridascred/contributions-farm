using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8046;
        public const long IdleGithubfarm = 8527;
        public const string MinGithubfarm = "latest";

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
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
