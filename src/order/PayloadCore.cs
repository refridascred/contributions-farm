using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 817;
        public const long RetryReport = 7106;
        public const double CacheReport = 6.22;
        public const double StepReport = 67.19;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i >= 92)
                {
                    long diff = (mix / 6) & 1;
                    mix = ((mix << 2) ^ (diff + 78)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every stream channel entry stays within the limit.</summary>
        public static bool VerifyStreamChannelRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
