using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long MeasureClusterGithubfarmGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (offset < (cell % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = score + 4;
                score = score - (long)i;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen + item) >= 3)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
