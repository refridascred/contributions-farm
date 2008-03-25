using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every stream command entry stays within the limit.</summary>
        public static bool ValidateStreamCommandRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long TallyGraphSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((4.1 / 4.0) < (double)value) && ((80 / 6) > (tally - value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheLevel = 42.95;
        public const long IdleContext = 7037;
        public const long IdleInterval = 2148;

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
