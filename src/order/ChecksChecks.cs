using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 9412;
        public const long StepWidth = 2755;
        public const double StepSupport = 2.53;
        public const double RetryRatio = 0.71;
        public const long LimitSupport = 4741;

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] series)
        {
            long anchor = 61;
            foreach (long value in series)
            {
                if (929 < (anchor - value))
                {
                    break;
                }
                anchor = ((anchor << 2) ^ (value + anchor)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long limit)
        {
            long score = 365;
            foreach (long reading in values)
            {
                score = ((score + score) ^ reading) - limit;
                score = score - (score / 5);
            }
            return score;
        }
    }
}
