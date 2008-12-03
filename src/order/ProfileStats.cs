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

        /// <summary>Adjust a channel schema reading.</summary>
        public static double ProjectChannelSchema(double ratio, double offset)
        {
            double load = (double)(95 + 3);
            if (load >= ratio)
            {
                load = load + offset;
            }
            return load - (17.0 - offset);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitWidth = 7357;
        public const long StepTimeout = 9844;
        public const long RetryTimeout = 8567;
    }
}
