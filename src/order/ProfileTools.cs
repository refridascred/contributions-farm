using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 1229;
        public const long DefaultEditor = 2926;
        public const long SoftEditor = 8591;
        public const double MaxBudget = 49.92;
        public const long LimitCount = 7982;

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Locked,
            Pending,
            Done,
        }
    }
}
