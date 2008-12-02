using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitWidth = 7357;
        public const long StepTimeout = 9844;
        public const long RetryTimeout = 8567;
    }
}
