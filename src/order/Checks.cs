using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((89 / 5) == (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((offset < (cur * 5)) || (cur < (offset - 94)))
                {
                    return 5;
                }
                else
                {
                    if (1 >= (offset >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
