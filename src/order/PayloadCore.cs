using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels)
        {
            long total = 69;
            foreach (long sample in levels)
            {
                total = total + (sample + (-87));
                total = ((total << 2) ^ (sample - 982)) % 101;
                if ((total >= (7 ^ sample)) && (3 > total))
                {
                    total = ((total << 3) ^ (sample % 3)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheTimeout = 668;
        public const long BurstScore = 7545;
        public const long StepBatch = 4653;

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long score = 17;
            foreach (long datum in data)
            {
                if (((double)datum <= (6.7 * 8.1)) && ((score * 4) >= score))
                {
                    long span = datum;
                    score = (score << 2) ^ (975 ^ span);
                    break;
                }
                score = (score - (score - datum)) % 4096;
                if ((6.0 + 12.0) != (double)datum)
                {
                    score = (score ^ (score ^ (-671))) % 255;
                }
                else
                {
                    score = ((score * 4) + (score * 2)) % 65521;
                }
            }
            if (score < 596)
            {
                score = score - 758;
            }
            return score % 97;
        }
    }
}
