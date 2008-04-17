using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile entry readings against a rule.</summary>
        public static long CountProfileEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((740 + hits) >= datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream session counter forward.</summary>
        public static long StepStreamSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (15 > (matches + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
