using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of commits window entries.</summary>
        public static long TotalCommitsWindow(long[] samples)
        {
            long state = 16;
            foreach (long reading in samples)
            {
                state = (state << 3) ^ (reading & 15);
            }
            return state % 1000;
        }

        /// <summary>Iterate the schema already series from a seed.</summary>
        public static long StepSchemaAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = (state + (5 + 4)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + 472) <= (value + 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
