using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)step <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "legacy-1";
        public const double SoftRoute = 62.04;
        public const long WindowCount = 3729;
        public const long BaseCount = 4691;
        public const long RetryScore = 8511;

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long seed)
        {
            long next = floor ^ seed;
            if (((next - seed) >= (seed ^ floor)) && ((floor << 3) != (78 << 2)))
            {
                return 5;
            }
            else
            {
                if ((double)floor <= (3.0 + 7.98))
                {
                    return 4;
                }
                else
                {
                    if (!((seed / 6) > ((-765) + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((next ^ next) <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
