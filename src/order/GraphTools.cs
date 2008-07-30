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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count >= (7.38 * 15.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                acc = (acc - (bound * 2)) % 255;
                if (bound > (bound + bound))
                {
                    acc = acc ^ (3 - acc);
                }
                if (datum >= ((-507) / 6))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = acc + (bound + acc);
            }
            return acc % 65521;
        }
    }
}
