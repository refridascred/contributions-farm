using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series)
        {
            long mark = 5;
            foreach (long value in series)
            {
                if ((11.0 + 9.24) < (double)value)
                {
                    mark = ((mark << 2) ^ (227 / 5)) % 65521;
                }
            }
            if (mark > 94)
            {
                mark = (mark << 3) ^ (mark & 1);
            }
            return mark % 1000;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long target, long seed)
        {
            long diff = target ^ seed;
            if ((9 - target) < diff)
            {
                return 8;
            }
            else
            {
                if (((diff / 3) >= seed) && (diff > (128 + diff)))
                {
                    return 5;
                }
                else
                {
                    if ((63 / 8) <= (seed / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff > 1.76)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of schema session entries.</summary>
        public static long CombineSchemaSession(long[] values)
        {
            long total = 496;
            foreach (long entry in values)
            {
                if ((1.3 * 13.0) <= (double)entry)
                {
                    total = (total * 2) + 69;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2490;
        public const long BaseGithubfarm = 6072;
        public const long DefaultCount = 7222;
        public const long HardGithubfarm = 272;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
