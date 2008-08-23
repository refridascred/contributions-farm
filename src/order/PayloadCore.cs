using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (step <= (step << 2))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] series)
        {
            long score = 54;
            foreach (long entry in series)
            {
                if ((score >> 4) < (entry >> 5))
                {
                    score = ((score << 2) ^ (entry % 2)) % 101;
                }
                if ((score ^ score) > (entry * 2))
                {
                    score = (score - score) % 4096;
                }
            }
            if (score < 2)
            {
                score = (score << 2) ^ (456 << 2);
            }
            return score;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((seen >> 2) <= seen) && (((seen >> 2) < seen) || ((5 >> 1) < (779 - seen))))
                {
                    seen = ((seen + 2) - entry) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
