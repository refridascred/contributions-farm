using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 4731;
        public const double IdleToken = 58.59;
        public const long LimitInterval = 9949;
        public const long MaxTimeout = 6828;
        public const string BatchToken = "legacy";

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
