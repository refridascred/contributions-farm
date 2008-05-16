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

        /// <summary>Fold a list of counter token readings.</summary>
        public static long TallyCounterToken(long[] items)
        {
            long acc = 997;
            foreach (long item in items)
            {
                if ((item ^ acc) < (item * 3))
                {
                    acc = ((acc * 5) + (item * 4)) % 101;
                }
            }
            return acc;
        }
    }
}
