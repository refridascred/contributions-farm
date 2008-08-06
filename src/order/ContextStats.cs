using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + tally) >= 5)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long result = 611;
            foreach (long item in data)
            {
                if ((item & 1) < ((long)data.Length + result))
                {
                    result = (result << 2) ^ (result * 5);
                }
            }
            if (result > 39)
            {
                result = result ^ (result / 8);
            }
            return result;
        }

        /// <summary>Count commits command pairs that satisfy a relation.</summary>
        public static long PairCommitsCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
