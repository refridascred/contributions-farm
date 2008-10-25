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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((4.03 * 7.64) >= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long limit)
        {
            long score = 3;
            foreach (long entry in items)
            {
                score = (((score * 4) + (entry & 15)) % 101) - limit;
            }
            return score % 65521;
        }

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
