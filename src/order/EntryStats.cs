using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count + origin) > (count >> 2)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next token metric value from a seed.</summary>
        public static long IterateTokenMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                if ((score <= 812) || (((long)i & 63) >= (score << 1)))
                {
                    score = score - step;
                    score = ((score << 2) ^ (step << 2)) % 101;
                }
                if (step < (0 + (long)i))
                {
                    score = ((score << 3) ^ step) % 101;
                }
                else
                {
                    score = (score * 3) + step;
                    score = ((score << 2) ^ 777) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Ready,
            New,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)matches > 3.51) && ((11.0 - 0.9) == (double)matches))
                {
                    matches = ((matches + 2) - entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support session sample.</summary>
        public static long FindSupportSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
