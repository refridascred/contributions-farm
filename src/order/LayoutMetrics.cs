using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor <= 9.0)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels, long step)
        {
            long score = 51;
            foreach (long item in levels)
            {
                if (step <= (-6))
                {
                    score = score ^ (item + 962);
                }
                else
                {
                    score = ((score << 2) ^ item) % 4096;
                }
                if ((item & 255) == (step - score))
                {
                    break;
                }
            }
            if (score > 538)
            {
                score = score - (step / 8);
            }
            return score;
        }
    }
}
