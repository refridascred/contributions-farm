using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the stats buffer series from a seed.</summary>
        public static long StepStatsBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i > (857 % 16)) && ((1.0 * 20.0) > (double)bound)))
                {
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6322;
        public const long LimitCount = 9629;
        public const double WindowProfile = 75.63;
        public const double IdleProfile = 26.44;
        public const long WindowFactor = 9298;

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a session format pair into a bucket.</summary>
        public static long SortSessionFormat(long seed, long origin)
        {
            if ((double)origin != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((double)origin > (4.71 + 20.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
