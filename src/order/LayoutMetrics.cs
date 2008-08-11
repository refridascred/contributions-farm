using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 16) <= item)
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] data)
        {
            long score = -171;
            foreach (long value in data)
            {
                if (((value % 100) > (score - value)) && (score < (value & 1)))
                {
                    score = (score - (value / 8)) % 65521;
                }
                if ((value ^ 6) < value)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
