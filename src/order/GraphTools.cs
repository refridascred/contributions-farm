using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if (((11.0 + 8.0) != (double)offset2) || ((1.0 + 16.0) < (double)offset))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 1.78) >= (double)offset3)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)sample >= 6.65))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "local-v2";
        public const string BaseWidth = "primary-v2";
        public const long MinLayout = 6797;
        public const long WindowLayout = 4935;

        /// <summary>Look up the position of a githubfarm cache sample.</summary>
        public static long SeekGithubfarmCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
