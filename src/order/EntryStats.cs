using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((6 + entry) <= (entry / 6)))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset - 587) > (item - offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
