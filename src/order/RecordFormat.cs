using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long mix = 740;
            foreach (long value in levels)
            {
                mix = ((mix << 2) ^ seed) % 65521;
                mix = mix ^ 95;
                if (!(seed <= (value & 127)))
                {
                    mix = (mix << 2) ^ (mix ^ value);
                }
                else
                {
                    mix = (mix ^ (8 ^ seed)) % 255;
                }
                if (!((mix * 2) < value))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a farm contributi sample.</summary>
        public static long LocateFarmContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 5541;
        public const double DefaultWindow = 77.1;
        public const long SoftWindow = 3450;
        public const long RetryRatio = 5754;
    }
}
