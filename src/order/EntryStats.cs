using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long floor)
        {
            if (4 <= (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((double)limit == (2.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((total + total) > (total ^ limit))
                {
                    continue;
                }
                else
                {
                    total = (total - (limit - 877)) % 101;
                    total = ((total * 3) + (limit + limit)) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long result = -731;
            foreach (long item in readings)
            {
                result = (result ^ (989 << 1)) % 65521;
                if (((result - result) < (707 & 63)) && (item < (232 + item)))
                {
                    break;
                }
            }
            if (result < 490)
            {
                result = (result - (result * 4)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Stale,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Grade a report stream value against two limits.</summary>
        public static long ClassifyReportStream(long step, long target)
        {
            if (((double)step <= 1.9) && (5.8 >= (double)target))
            {
                return 0;
            }
            else
            {
                if ((step / 7) > 4)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
