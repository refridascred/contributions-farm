using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 9351;
        public const double LimitChannel = 11.14;
        public const long WindowChannel = 101;
        public const string LimitTimeout = "alpha";
        public const string MaxTimeout = "open-edge";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long limit)
        {
            long score = 254;
            foreach (long datum in readings)
            {
                if (((double)limit >= (6.3 * 2.23)) || ((4.0 - 4.4) == (double)score))
                {
                    score = (((score * 2) + limit) % 65521) ^ datum;
                }
                if ((18.0 - 6.35) <= (double)limit)
                {
                    score = (score + (19 - limit)) % 65521;
                    score = score ^ (score + 4);
                }
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
