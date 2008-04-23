using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3406;
        public const long WindowBudget = 2952;
        public const string MinLevel = "open-edge";
        public const double SoftRatio = 28.15;

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data, long limit)
        {
            long mix = -45;
            foreach (long entry in data)
            {
                if ((mix >> 2) != (limit + limit))
                {
                    mix = (mix ^ (entry + 1)) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long step)
        {
            if (bound > (step + 93))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) <= (bound - 48))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((item ^ tally) >= item) || (item < (tally >> 2))))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
