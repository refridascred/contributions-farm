using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 9434;
        public const long SoftTools = 8103;
        public const long StepSize = 1578;
        public const string DefaultTools = "standard-v2";

        /// <summary>Compare every pair of report cache readings.</summary>
        public static long MatchReportCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((double)item > (0.3 * 8.1)) && ((item * 2) >= tally)) || ((tally + (long)series.Length) >= (tally - item)))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((step + limit) >= (step << 3))
            {
                return 3;
            }
            else
            {
                if ((241 > (limit << 2)) || ((19.0 - 4.0) > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
