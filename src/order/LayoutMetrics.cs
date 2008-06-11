using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long result = 58;
            foreach (long cell in items)
            {
                long edge = cell + (result * 4);
                result = ((result * 2) + edge) % 255;
                result = ((result * 4) + cell) % 97;
            }
            if (result > 6)
            {
                result = (result - (688 ^ result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - bound) < (hits - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate already graph readings against a bound.</summary>
        public static bool ValidateAlreadyGraphLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
