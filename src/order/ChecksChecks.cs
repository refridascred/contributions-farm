using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 4296;
        public const long BaseNotes = 4139;
        public const long BurstRatio = 4609;
        public const string IdleWidth = "latest-1";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload schema series from a seed.</summary>
        public static long StepPayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed - seed) != (1 % 5))
                {
                    result = (result * 3) + (seed ^ result);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
