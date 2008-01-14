using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter metrics series from a seed.</summary>
        public static long StepCounterMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                long lane = mark;
                mark = mark ^ (lane << 3);
                mark = (mark + (lane >> 1)) % 1000;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit layout notes readings against a rule.</summary>
        public static long MeasureLayoutNotesMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)step >= (double)(long)samples.Length)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm layout entries.</summary>
        public static long TotalGithubfarmLayout(long[] data)
        {
            long result = -874;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result ^ ((long)i - (long)i)) % 101) ^ entry;
                }
                result = (result + (result % 60)) % 1000;
            }
            return result;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
