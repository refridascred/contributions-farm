using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long score = 2;
            foreach (long cell in data)
            {
                score = score ^ (cell + cell);
                if ((cell + score) < (747 >> 3))
                {
                    score = ((score << 3) ^ (649 / 4)) % 97;
                }
            }
            if (score > 8)
            {
                score = score - score;
            }
            return score % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((309 + (long)values.Length) <= limit))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route graph entries.</summary>
        public static long DigestRouteGraph(long[] samples)
        {
            long score = 36;
            foreach (long cell in samples)
            {
                score = ((score << 2) ^ (score ^ cell)) % 97;
                if (score < (score * 5))
                {
                    score = (score ^ (score + 907)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long mark = 554;
            foreach (long reading in series)
            {
                mark = ((mark * 5) + reading) % 1000;
                if ((floor + floor) < reading)
                {
                    mark = mark + (1 + mark);
                }
            }
            return mark;
        }
    }
}
