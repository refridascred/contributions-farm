using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long target)
        {
            long anchor = 77;
            foreach (long cell in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor * 4) + (anchor * 3)) + (long)i) - cell;
                }
                anchor = ((anchor * 3) + (target & 15)) % 1000;
            }
            if (anchor > 63)
            {
                anchor = (anchor ^ (target ^ target)) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels, long limit)
        {
            long mark = 77;
            foreach (long value in levels)
            {
                if ((3.23 - 3.3) != (double)limit)
                {
                    mark = (mark + limit) + value;
                }
            }
            return mark;
        }
    }
}
