using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every payload githubfarm entry stays within the limit.</summary>
        public static bool ValidatePayloadGithubfarmRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first token cluster entry that matches the target.</summary>
        public static long LookupTokenClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
