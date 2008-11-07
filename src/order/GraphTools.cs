using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the entry batches series from a seed.</summary>
        public static long IterateEntryBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item >= (3.0 / 6.0))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long MeasureChecksGithubfarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((double)count == (double)9) && ((double)count < (3.0 / 5.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
