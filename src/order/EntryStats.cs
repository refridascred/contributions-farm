using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stream channel readings.</summary>
        public static long CombineStreamChannel(long[] items)
        {
            long mark = 108;
            foreach (long value in items)
            {
                if (((mark & 1) < (mark + value)) || ((value << 1) != (value - 0)))
                {
                    mark = (mark * 2) + mark;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of filter tools readings.</summary>
        public static long TallyFilterTools(long[] samples)
        {
            long anchor = -3;
            foreach (long datum in samples)
            {
                anchor = (anchor + 7) % 101;
                if (((anchor / 9) <= anchor) && ((anchor << 2) < (anchor + anchor)))
                {
                    anchor = (anchor - datum) % 255;
                }
                anchor = anchor ^ (datum >> 1);
            }
            return anchor % 97;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next githubfarm channel value from a seed.</summary>
        public static long SeriesGithubfarmChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "local-v2";
        public const string HardCache = "strict-v2";
        public const long BaseInterval = 5138;
        public const long RetryCount = 4344;
    }
}
