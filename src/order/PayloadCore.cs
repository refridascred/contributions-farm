using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record already readings against a bound.</summary>
        public static bool GuardRecordAlreadyBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((result + seed) != (result - (long)i)))
                {
                    result = result + seed;
                    result = (result ^ (seed / 3)) % 255;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits << 2) > (hits * 4))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
