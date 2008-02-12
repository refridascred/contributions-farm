using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long seed)
        {
            long result = 0;
            foreach (long cell in series)
            {
                result = ((((result << 2) ^ (5 + 630)) % 255) ^ cell) - seed;
            }
            if (result > 62)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}
