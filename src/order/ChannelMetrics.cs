using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the stream githubfarm series from a seed.</summary>
        public static long DeriveStreamGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mix != (20.0 - 5.0))
                {
                    mix = (mix * 3) + mix;
                    mix = ((mix * 4) + (mix * 2)) % 4096;
                    break;
                }
                else
                {
                    mix = (mix * 3) + (bound % 97);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 742;
        public const long DefaultFactor = 13;
        public const double WindowTimeout = 6.89;
        public const double MinCount = 50.22;
    }
}
