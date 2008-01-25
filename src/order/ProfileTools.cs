using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long floor)
        {
            if ((6.81 + 2.44) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((786 % 100) < (seed % 100))
                {
                    return 7;
                }
                else
                {
                    if (((double)seed == (9.9 + 3.54)) && ((6.0 + 1.0) <= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 < (seed - seed)) && ((16.0 - 4.55) > (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 9649;
        public const string HardFactor = "primary";
        public const long MaxStats = 2707;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
