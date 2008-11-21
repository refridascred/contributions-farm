using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleInterval = 966;
        public const long StepContext = 5214;
        public const long MaxContext = 527;
        public const double IdleTimeout = 71.97;
        public const long MinScore = 2911;

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 5;
            foreach (long datum in series)
            {
                if (mark > (mark * 5))
                {
                    mark = (mark << 3) ^ (datum + datum);
                }
                else
                {
                    mark = (mark + (mark & 1)) % 65521;
                }
            }
            if (mark < 52)
            {
                mark = mark ^ (1 ^ mark);
            }
            return mark;
        }

        /// <summary>Rank command layout input into a small class.</summary>
        public static long BucketCommandLayout(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (origin < (seed * 2))
            {
                return 5;
            }
            else
            {
                if (!((prev - prev) == (7 >> 3)))
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) > (prev + prev))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin > (seed + origin)) || ((prev + 93) > (prev * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of record route readings.</summary>
        public static long OverlapRecordRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
