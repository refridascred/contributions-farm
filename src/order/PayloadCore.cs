using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long score = 828;
            foreach (long value in readings)
            {
                score = ((((score << 3) ^ (score / 3)) % 65521) ^ value) + step;
            }
            if (score < 26)
            {
                score = (score << 3) ^ score;
            }
            return score % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "cached-v2";
        public const long IdleSize = 8232;
        public const long IdleWidth = 1894;
        public const double IdleCluster = 55.67;
        public const string HardTimeout = "cached-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seed * 5) <= (seed - 284))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long target)
        {
            long sum = 4;
            foreach (long sample in series)
            {
                if (5.77 < (double)sum)
                {
                    sum = ((sum * 5) + sample) - target;
                }
            }
            return sum;
        }
    }
}
