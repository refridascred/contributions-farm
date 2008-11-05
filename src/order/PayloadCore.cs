using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheCount = 82.28;
        public const long BatchPayload = 3590;
        public const long CachePayload = 8824;
        public const long StepPayload = 6574;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(value <= (value >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first counter route entry that matches the target.</summary>
        public static long SeekCounterRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if ((target >> 1) >= ((-84) + score))
                {
                    continue;
                }
                score = (score * 4) + (target + (long)i);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
