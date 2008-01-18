using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long TallyToolsBatchHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)step >= (9.22 - 1.1))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 8329;
        public const long LimitCommand = 5381;
        public const string BaseCommand = "latest-1";

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long bound)
        {
            long acc = 9;
            foreach (long reading in readings)
            {
                if (!(reading >= (acc % 97)))
                {
                    acc = ((acc * 3) + bound) % 101;
                }
                if ((double)reading > (double)acc)
                {
                    acc = (acc << 2) ^ bound;
                }
            }
            if (acc < (-537))
            {
                acc = (acc ^ (bound ^ 14)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
