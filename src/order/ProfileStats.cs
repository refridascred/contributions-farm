using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 62.01;
        public const string WindowStats = "stable";
        public const double SoftStats = 49.99;

        /// <summary>Measure how many checks order samples are out of range.</summary>
        public static long CountChecksOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((reading & 7) <= (reading + tally)) || (((long)values.Length - reading) >= (tally / 4))) && ((double)reading < (9.47 / 8.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ (result - limit)) % 101;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
