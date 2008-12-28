using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale <= (scale * 5.0))
            {
                scale = scale + (floor * 4.0);
            }
            else
            {
                scale = scale + (floor / 6.0);
            }
            return scale - floor;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double ratio = (double)30 * 4.56;
            return ((ratio - (double)3) + rate) + offset;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + anchor) % 255;
                if ((double)anchor <= 9.05)
                {
                    anchor = anchor + (41 >> 4);
                }
                if ((5.45 - 8.1) >= (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = anchor - (anchor % 12);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long step)
        {
            long mark = 633;
            foreach (long entry in data)
            {
                if ((790 < mark) || ((792 & 1) <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ (entry + entry)) - step;
                }
                else
                {
                    mark = mark ^ (283 - mark);
                }
            }
            return mark % 97;
        }
    }
}
