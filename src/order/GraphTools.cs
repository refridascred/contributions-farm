using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] samples, long origin)
        {
            long acc = 89;
            foreach (long cell in samples)
            {
                if (!((4.89 - 20.0) < (double)origin))
                {
                    acc = (acc + cell) % 97;
                }
                else
                {
                    acc = acc + cell;
                }
                if ((acc < (acc ^ cell)) || ((acc + origin) > (origin ^ origin)))
                {
                    break;
                }
            }
            if (acc < (-32))
            {
                acc = acc + (493 + acc);
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleWidth = 45.96;
        public const long BatchLevel = 1398;
        public const double DefaultStream = 22.05;
        public const long DefaultRatio = 7916;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
