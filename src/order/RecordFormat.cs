using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the notes support series from a seed.</summary>
        public static long RollNotesSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 2) ^ ((long)i ^ 3);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total * 2) + (-79)) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank filter command input into a small class.</summary>
        public static long BucketFilterCommand(long limit, long offset)
        {
            long gap = limit + offset;
            if (!(limit <= (gap * 5)))
            {
                return 6;
            }
            else
            {
                if (limit < (limit % 64))
                {
                    return 0;
                }
                else
                {
                    if (((offset * 2) > (limit << 3)) || ((0.9 * 9.7) == (double)limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((gap >= (806 - offset)) && ((offset + offset) >= (76 / 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
