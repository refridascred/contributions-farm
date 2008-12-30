using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - load) + (double)(long)i) - span;
            }
            return load + weight;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double weight, double floor)
        {
            double drift = floor;
            if (drift < drift)
            {
                drift = drift + (1.7 / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor - weight)) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((237 + cell) != (cell << 3)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long mark = 33;
            foreach (long cell in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark ^ (mark >> 1)) % 255) - (long)i;
                }
                if ((((-22) + cell) > cell) && ((double)cell < (0.68 + 3.2)))
                {
                    mark = mark - (6 << 2);
                }
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= (90 << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
