using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank commits payload input into a small class.</summary>
        public static long SortCommitsPayload(long target, long bound)
        {
            long offset = target + bound;
            if ((95 ^ offset) < (target >> 2))
            {
                return 6;
            }
            else
            {
                if (((offset ^ bound) >= offset) || (bound <= (bound << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound + 30) <= (offset - 59))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
