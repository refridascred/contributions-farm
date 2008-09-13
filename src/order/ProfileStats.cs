using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a commits command sample.</summary>
        public static long LookupCommitsCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Pending,
            New,
            Ready,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "open";
        public const long MaxRatio = 9191;
        public const long BaseCommand = 1639;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
