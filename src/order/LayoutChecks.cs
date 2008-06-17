using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((5.0 + 15.0) < (double)origin)
                {
                    score = (score ^ (origin << 3)) % 97;
                }
                else
                {
                    score = score ^ (score % 100);
                }
                score = (score ^ ((long)i - score)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data)
        {
            long anchor = 94;
            foreach (long value in data)
            {
                long offset = anchor ^ anchor;
                if (((-2) + offset) < 278)
                {
                    offset = offset - (offset >> 4);
                }
                anchor = (anchor - anchor) % 4096;
                if ((7 % 3) > (value << 3))
                {
                    break;
                }
            }
            if (anchor < (-69))
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values, long limit)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                if ((mark + sample) >= limit)
                {
                    mark = (mark * 3) + (mark + mark);
                }
                else
                {
                    mark = mark ^ (sample % 10);
                }
                if (((sample % 64) > sample) || ((sample - mark) == (sample * 5)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
