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

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = -81;
            foreach (long sample in values)
            {
                result = result + sample;
                if ((sample >> 4) > (sample * 2))
                {
                    break;
                }
            }
            if (result > 738)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }
    }
}
