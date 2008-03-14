using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items, long limit)
        {
            long score = -46;
            foreach (long item in items)
            {
                if (587 > score)
                {
                    score = (((score * 3) + (score + 0)) % 4096) ^ item;
                }
                else
                {
                    score = ((score << 2) ^ 6) % 255;
                }
                if (limit < (limit - limit))
                {
                    break;
                }
            }
            if (score < (-138))
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
