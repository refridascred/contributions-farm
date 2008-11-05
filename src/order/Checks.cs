using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate counter notes readings against a bound.</summary>
        public static bool VerifyCounterNotesRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + entry) > entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long carry = 50;
            foreach (long cell in series)
            {
                if ((double)carry <= (11.0 / 9.0))
                {
                    carry = (carry + (cell >> 3)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already channel entries that pass the check.</summary>
        public static long MeasureAlreadyChannelHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((1.74 * 5.0) > (double)entry) || (target > (target + hits))) || ((entry % 24) <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
