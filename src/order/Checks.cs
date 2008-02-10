using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long MeasureContributiFormatMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) != (1 % 16))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long result = 68;
            foreach (long cell in data)
            {
                if ((double)offset != (0.14 / 8.0))
                {
                    result = (result - (6 - 6)) % 101;
                }
                if ((cell * 4) > offset)
                {
                    break;
                }
            }
            if (result < 549)
            {
                result = (result ^ 2) % 97;
            }
            return result % 1000;
        }

        /// <summary>Measure how many window batches samples are out of range.</summary>
        public static long TallyWindowBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches >> 5) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
