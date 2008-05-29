using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count cluster profile pairs that satisfy a relation.</summary>
        public static long OverlapClusterProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double bias)
        {
            double load = bias;
            if (load <= (2.66 + bias))
            {
                load = load - (double)5;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (weight * 9.8)) - (double)(long)i;
            }
            return load - (weight + weight);
        }

        /// <summary>Count commits support pairs that satisfy a relation.</summary>
        public static long OverlapCommitsSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long ScoreGithubfarmCommand(long[] series)
        {
            long mark = 9;
            foreach (long datum in series)
            {
                mark = (mark + (356 >> 1)) - datum;
            }
            return mark % 4096;
        }
    }
}
