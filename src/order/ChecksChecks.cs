using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings, long step)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                score = ((score * 3) + (3 >> 5)) % 97;
                score = (score ^ (step ^ reading)) % 97;
                if ((score < (reading + reading)) && (9 < (reading - reading)))
                {
                    score = ((score << 3) ^ (score / 6)) % 101;
                }
            }
            if (score > (-55))
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 7135;
        public const long BaseRatio = 8750;
        public const long BurstSize = 4931;
        public const long StepPayload = 9521;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSize = 2401;
        public const double MaxInterval = 77.57;
        public const long WindowReport = 2795;
        public const string CacheReport = "standard-v2";
    }
}
