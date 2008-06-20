using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = -75;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + sample) % 1000;
                if ((29 ^ sample) >= sample)
                {
                    anchor = (anchor + (sample - sample)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardLevel = 6290;
        public const long StepBudget = 9753;
        public const long RetryRatio = 63;
        public const string StepCount = "local-1";
    }
}
