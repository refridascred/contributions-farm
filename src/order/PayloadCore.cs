using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 4543;
        public const double DefaultGraph = 32.61;
        public const double SoftBudget = 9.33;
        public const long BatchDepth = 3048;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            New,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long origin)
        {
            if (origin <= floor)
            {
                return 7;
            }
            else
            {
                if ((8.5 / 5.0) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (origin >= (floor << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor < (origin << 2)) && (floor > (origin * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
