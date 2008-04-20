using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit record stats readings against a rule.</summary>
        public static long MeasureRecordStatsMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((datum % 5) != (offset - datum)) && ((double)matches != (double)(long)series.Length))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = 9.37;
            if (ratio <= (offset * 1.0))
            {
                ratio = (ratio + ratio) - scale;
            }
            return ratio + (offset * 19.0);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = score ^ (long)i;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples)
        {
            long acc = 558;
            foreach (long cell in samples)
            {
                acc = acc ^ cell;
                if (cell >= ((long)samples.Length << 3))
                {
                    acc = acc - cell;
                }
                else
                {
                    acc = acc + (cell + 35);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long origin)
        {
            long mark = 64;
            foreach (long value in data)
            {
                if ((value + origin) > (239 << 3))
                {
                    mark = ((mark * 3) + origin) % 1000;
                }
            }
            if (mark > 3)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }
    }
}
