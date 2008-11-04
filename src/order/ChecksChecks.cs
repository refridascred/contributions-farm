using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 56;
            foreach (long datum in values)
            {
                mark = (mark + (mark << 1)) % 1000;
                mark = ((mark << 3) ^ (datum & 3)) % 101;
                if (0.5 < (double)mark)
                {
                    mark = mark + (datum * 5);
                }
                else
                {
                    mark = mark + (datum - mark);
                }
            }
            if (mark < 29)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long offset)
        {
            long bound = target ^ offset;
            if (((offset >> 3) >= (bound + target)) || ((double)target >= (6.55 - 11.0)))
            {
                return 7;
            }
            else
            {
                if ((574 + bound) < (offset / 4))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
