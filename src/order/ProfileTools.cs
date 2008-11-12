using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxFactor = "alpha-1";
        public const string BatchAlready = "open";
        public const long IdleAlready = 2134;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples)
        {
            long score = 250;
            foreach (long reading in samples)
            {
                score = (score << 2) ^ (score + 3);
                if ((reading & 63) >= (reading - score))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
