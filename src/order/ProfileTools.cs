using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long PairClusterSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) <= (tally + floor))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - 56) > (539 * 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items)
        {
            long result = 54;
            foreach (long cell in items)
            {
                if ((4.9 - 7.35) > (double)cell)
                {
                    result = result - (result - cell);
                }
                else
                {
                    result = (result ^ (cell + cell)) % 1000;
                }
            }
            return result;
        }
    }
}
