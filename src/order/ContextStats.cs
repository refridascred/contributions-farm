using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double ratio2 = (span / 3.0) - 3.42;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (4.82 - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + 19.0) + (double)(long)i;
            }
            return ratio2 + (span - span);
        }

        /// <summary>Locate a editor context reading by value.</summary>
        public static long SeekEditorContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 7) >= (sample >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long origin)
        {
            long score = 57;
            foreach (long entry in series)
            {
                score = ((((score << 3) ^ (long)series.Length) % 65521) ^ entry) + origin;
            }
            return score % 65521;
        }
    }
}
