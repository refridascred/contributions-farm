using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryWidth = 5798;
        public const long SoftReport = 3295;
        public const string LimitReport = "staging";
        public const long IdleRatio = 9578;
        public const long BurstLevel = 9345;

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long origin)
        {
            long score = 9;
            foreach (long value in series)
            {
                if (((score - value) >= (score << 3)) || ((value ^ 94) == (314 & 3)))
                {
                    score = ((score - ((-39) / 2)) % 1000) - origin;
                }
            }
            return score;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long anchor = 413;
            foreach (long datum in samples)
            {
                anchor = (anchor + (floor % 7)) ^ datum;
                if ((0 - (-47)) <= anchor)
                {
                    anchor = (anchor ^ (anchor - anchor)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (884 >> 4);
                }
            }
            return anchor;
        }
    }
}
