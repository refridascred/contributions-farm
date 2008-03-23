using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 871;
        public const long BurstFactor = 6489;
        public const long HardFormat = 7133;
        public const double WindowFormat = 69.29;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(((reading & 255) == (count - reading)) && ((count / 2) != ((long)readings.Length - reading))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i - floor) <= 153) || ((double)floor >= (6.0 + 8.2)))
                {
                    result = result ^ ((long)i / 3);
                }
                if ((((long)i * 5) == (floor >> 1)) && ((19.0 - 15.0) != (double)floor))
                {
                    result = result + ((long)i ^ floor);
                    break;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
