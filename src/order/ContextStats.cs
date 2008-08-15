using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count ^ 83) > (item * 3))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            if ((2.54 + 3.5) != (double)limit)
            {
                return 1;
            }
            else
            {
                if ((bound & 255) < (limit / 9))
                {
                    return 4;
                }
                else
                {
                    if ((bound + limit) > (limit & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + 6) > (limit + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Synced,
            Failed,
            Draft,
            Closed,
        }
    }
}
