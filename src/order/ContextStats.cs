using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((datum % 5) != (datum & 31)) || (5.28 < (double)datum)) && ((5 + (long)samples.Length) > 80))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine stats tools values into a single score.</summary>
        public static long DigestStatsTools(long[] samples)
        {
            long mix = 82;
            foreach (long datum in samples)
            {
                if ((mix << 1) >= ((long)samples.Length - mix))
                {
                    mix = (mix << 3) ^ datum;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            return mix;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
