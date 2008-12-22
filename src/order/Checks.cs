using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 2725;
        public const long LimitSpan = 6361;
        public const long HardBudget = 4084;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result * 4) + bound) ^ (long)i2;
                }
                if ((result - bound) < bound)
                {
                    result = result + (long)i;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Queued,
            Done,
        }
    }
}
