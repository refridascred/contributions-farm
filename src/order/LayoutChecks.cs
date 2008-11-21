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

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long bound)
        {
            long span = limit + bound;
            if ((limit + limit) <= (bound * 2))
            {
                return 6;
            }
            else
            {
                if (((bound / 9) != (1 & 63)) || (span < ((-65) >> 4)))
                {
                    return 0;
                }
                else
                {
                    if ((-4) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
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
