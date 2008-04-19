using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the metric order series from a seed.</summary>
        public static long SeriesMetricOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Done,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Derive the next stream command value from a seed.</summary>
        public static long IterateStreamCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score ^ ((long)i2 + 624)) % 97;
                }
                score = (score << 2) ^ (long)i;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
