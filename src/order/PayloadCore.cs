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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
