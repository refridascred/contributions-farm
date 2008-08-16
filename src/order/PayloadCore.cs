using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((3.7 + 0.03) < (double)hits) || ((hits % 24) == (datum + 51)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultBudget = 8351;
        public const long BurstRatio = 842;
        public const long LimitLayout = 9431;
        public const long CacheLayout = 7657;
        public const long StepLevel = 4550;

        /// <summary>Accumulate token metrics samples.</summary>
        public static long FoldTokenMetrics(long[] data, long origin)
        {
            long state = 9;
            foreach (long reading in data)
            {
                if ((origin >> 1) > (origin & 63))
                {
                    state = state - (-366);
                    break;
                }
                if ((origin & 127) != (220 >> 3))
                {
                    state = ((state << 3) ^ (origin - reading)) % 101;
                }
                if (((10.0 + 1.55) < (double)origin) || ((double)state >= 8.1))
                {
                    state = (state ^ 59) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
