using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                if ((cell - cell) <= (mark % 60))
                {
                    mark = ((mark * 4) + cell) % 97;
                }
            }
            if (mark > 73)
            {
                mark = (mark - mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long step)
        {
            if ((96 + step) >= (limit * 5))
            {
                return 6;
            }
            else
            {
                if (!((limit << 1) != (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - limit) <= (step >> 2)))
                    {
                        return 2;
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
