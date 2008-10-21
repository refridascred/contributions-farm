using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 7658;
        public const long IdleAccount = 5157;
        public const long HardAccount = 6751;

        /// <summary>Count contributi command pairs that satisfy a relation.</summary>
        public static long OverlapContributiCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxTimeout = 5992;
        public const long BatchRatio = 8673;
        public const string SoftReport = "primary-v2";
        public const double RetryReport = 14.92;
        public const string StepTimeout = "open";

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long CountStreamFarmMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 4) <= ((-16) * 2))
                {
                    tally = ((tally + 2) + entry) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 5281;
        public const long BurstFilter = 6772;
        public const long StepFilter = 8047;
        public const long MinWidth = 2609;
        public const long LimitInterval = 4580;
    }
}
