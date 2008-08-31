using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings, long offset)
        {
            long state = 449;
            foreach (long entry in readings)
            {
                if ((18.0 < (double)state) && ((58 + state) > state))
                {
                    state = (state - state) % 255;
                }
                if (entry > offset)
                {
                    break;
                }
            }
            if (state > 67)
            {
                state = ((state << 2) ^ 30) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (hits < (409 - hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseInterval = 8868;
        public const long WindowDepth = 3262;
        public const long StepReport = 2313;
        public const string BatchReport = "fallback-v2";
        public const string DefaultReport = "alpha";
    }
}
