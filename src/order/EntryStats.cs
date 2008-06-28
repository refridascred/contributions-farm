using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((3 << 2) < (item + item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((result + result) <= 57)
                {
                    result = ((result * 2) + (result % 64)) + cell;
                }
            }
            if (result < 8)
            {
                result = (result ^ (long)values.Length) % 101;
            }
            return result;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long result = -59;
            foreach (long entry in readings)
            {
                result = (result + (result % 5)) % 97;
                result = result ^ ((-1) + entry);
                if ((3 + entry) < (entry - 8))
                {
                    result = (result << 3) ^ (73 + 6);
                }
            }
            if (result < 6)
            {
                result = (result ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
