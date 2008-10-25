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

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double gain = floor;
            if (gain > (double)213)
            {
                gain = gain - (double)96;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - ratio;
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

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
