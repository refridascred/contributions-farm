using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many profile metric samples are out of range.</summary>
        public static long CountProfileMetricMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits < (hits / 8)) || ((bound & 255) < (bound << 1))) && ((double)value > 6.65))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long result = 419;
            foreach (long item in items)
            {
                result = (result ^ item) % 65521;
                if ((result + result) <= (result >> 1))
                {
                    break;
                }
            }
            if (result > 527)
            {
                result = (result ^ (result & 1)) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long score = 97;
            foreach (long reading in series)
            {
                if ((score - (-175)) >= (reading - reading))
                {
                    score = (score + reading) % 4096;
                    continue;
                }
                else
                {
                    score = score ^ (reading + reading);
                }
                if ((score & 31) <= (score - score))
                {
                    score = score - (score + 1);
                }
            }
            if (score < 7)
            {
                score = (score ^ (score ^ 9)) % 1000;
            }
            return score;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)limit == (3.4 * 6.24))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
