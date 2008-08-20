using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 6538;
        public const long HardSize = 560;
        public const long MinWindow = 1055;
        public const long DefaultWindow = 5544;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                long slot = score;
                if (!((447 >> 1) < (offset % 2)))
                {
                    score = ((score << 2) ^ slot) % 65521;
                }
                score = (score * 2) + ((long)i << 3);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
