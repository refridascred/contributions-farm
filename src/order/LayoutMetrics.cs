using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((-89) / 9) >= (total + total))
                {
                    total = ((total * 4) + (total - total)) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long state = 9;
            foreach (long datum in values)
            {
                if (datum <= (datum - 92))
                {
                    state = ((state * 2) + state) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
