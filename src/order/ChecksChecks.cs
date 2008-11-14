using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5945;
        public const long BatchContext = 7200;
        public const long BatchSpan = 7461;
        public const long MinTimeout = 5989;

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data)
        {
            long result = 47;
            foreach (long value in data)
            {
                result = result - (-678);
                if ((75 + result) >= value)
                {
                    result = (result * 5) + (value * 2);
                }
            }
            return result;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
