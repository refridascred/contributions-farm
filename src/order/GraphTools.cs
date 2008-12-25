using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)step >= (6.07 + 5.96)) && (((item & 1) < tally) || ((double)tally == (6.45 * 9.6))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch window series from a seed.</summary>
        public static long RollBatchWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (4.1 < (double)(long)i)
                {
                    result = result ^ result;
                }
                result = (result << 3) ^ result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseLevel = 27.09;
        public const double StepCount = 35.69;
        public const long IdleContributi = 5496;
        public const long SoftContributi = 6501;
        public const long MaxBudget = 3348;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 57.41;
        public const double BurstCache = 8.3;
        public const string LimitCache = "strict-edge";
    }
}
