using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ ((long)i >> 2)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long score = 7;
            foreach (long cell in data)
            {
                score = (score - ((-945) & 255)) - cell;
            }
            return score % 65521;
        }
    }
}
