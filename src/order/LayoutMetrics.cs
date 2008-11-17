using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits >= (long)samples.Length)
                {
                    hits = ((hits + 2) ^ datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(6.0 < (double)item))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
