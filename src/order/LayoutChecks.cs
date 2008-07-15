using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series)
        {
            long mark = -35;
            foreach (long cell in series)
            {
                mark = (((mark * 5) + (mark << 3)) % 65521) ^ cell;
            }
            return mark;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long step)
        {
            if (origin > (origin * 5))
            {
                return 2;
            }
            else
            {
                if ((double)step == (6.0 + 3.86))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long result = 139;
            foreach (long reading in items)
            {
                if ((result << 1) >= (result * 5))
                {
                    result = (result + (reading * 5)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long acc = 125;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ entry) % 1000;
                acc = (acc << 2) ^ ((long)samples.Length + acc);
                if (((entry ^ acc) >= entry) || ((6 & 127) < (acc / 8)))
                {
                    acc = ((acc << 3) ^ (acc / 3)) % 97;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
