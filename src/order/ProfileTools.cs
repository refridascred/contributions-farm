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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 7336;
        public const string StepDepth = "strict";
        public const long MinStream = 8072;
        public const long BaseStream = 6080;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches - limit) <= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] items, long target)
        {
            long acc = 705;
            foreach (long entry in items)
            {
                acc = (acc ^ (acc - target)) % 65521;
                if ((acc & 31) >= (target - acc))
                {
                    acc = (acc ^ (acc + entry)) % 1000;
                }
                if (1 < acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
