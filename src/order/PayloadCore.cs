using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 4012;
        public const long SoftSpan = 7384;
        public const long SoftScore = 3392;
        public const long MaxFormat = 4700;

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool ValidateReportAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long bound, long origin)
        {
            if (bound < (origin * 4))
            {
                return 2;
            }
            else
            {
                if (((bound * 4) < (bound / 2)) && ((double)origin >= (double)697))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
