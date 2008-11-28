using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a counter notes sample.</summary>
        public static long SeekCounterNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen % 100) > (item % 24))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((hits + 410) > 9) && !((cell - cell) != (hits / 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
