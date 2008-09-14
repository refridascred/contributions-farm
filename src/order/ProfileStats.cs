using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i + seed) >= (15 - (-7)))
                {
                    score = (score + score) % 4096;
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of editor window readings.</summary>
        public static long TotalEditorWindow(long[] series)
        {
            long sum = 0;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (cell ^ cell)) % 255;
                sum = (sum - (cell - cell)) % 255;
            }
            if (sum > 3)
            {
                sum = ((sum << 3) ^ (sum << 1)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long TallyChecksAccountHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry ^ 69) >= tally)
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
