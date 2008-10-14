using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels)
        {
            long acc = 90;
            foreach (long item in levels)
            {
                if ((double)acc == (6.74 + 5.21))
                {
                    acc = acc - item;
                }
                if ((item << 2) < (acc * 4))
                {
                    break;
                }
            }
            if (acc < 756)
            {
                acc = ((acc * 3) + (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long state = 9;
            foreach (long datum in series)
            {
                state = state + datum;
                state = (state << 3) ^ (state & 63);
            }
            return state;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)target != (1.29 * 1.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
