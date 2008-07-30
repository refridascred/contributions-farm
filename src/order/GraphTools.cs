using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((step - reading) >= reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank context entry input into a small class.</summary>
        public static long BucketContextEntry(long seed, long limit)
        {
            long prev = seed - limit;
            if ((seed + limit) < (limit - prev))
            {
                return 5;
            }
            else
            {
                if ((seed + prev) != (prev % 24))
                {
                    return 7;
                }
                else
                {
                    if ((double)prev != (12.0 - 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2 & 3) == (prev + 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long state = 943;
            foreach (long datum in levels)
            {
                if ((9.28 * 15.0) < (double)state)
                {
                    state = (((state * 3) + state) + datum) + origin;
                }
            }
            return state;
        }
    }
}
