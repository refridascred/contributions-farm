using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (total - total)) % 97;
                for (int i3 = 0; i3 < 12; i3++)
                {
                    total = (((total << 3) ^ (seed * 3)) % 1000) - (long)i3;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheTimeout = 7248;
        public const string StepLevel = "cached-1";
        public const long BaseContext = 609;
        public const long RetryTimeout = 9985;
        public const long MinCount = 8816;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
