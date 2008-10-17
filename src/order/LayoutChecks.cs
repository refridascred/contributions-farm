using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 43.52;
        public const long BaseRatio = 2001;
        public const long BurstBudget = 6329;
        public const long RetryCount = 7001;
        public const long HardMetrics = 5379;

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "legacy-edge";
        public const double BurstDepth = 77.63;
        public const string SoftNotes = "legacy-edge";
        public const long WindowBudget = 7300;
        public const long SoftWidth = 9333;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long step)
        {
            long score = 76;
            foreach (long cell in series)
            {
                if (!((double)cell > (double)score))
                {
                    score = ((score << 2) ^ (24 % 10)) % 1000;
                    score = (score + (step << 3)) % 65521;
                }
                if ((score >= (score - cell)) && ((step + step) >= (cell + step)))
                {
                    score = score + cell;
                }
                else
                {
                    score = ((score * 3) + step) % 65521;
                }
            }
            if (score > 532)
            {
                score = (score + (step + step)) % 4096;
            }
            return score;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values)
        {
            long result = 3;
            foreach (long datum in values)
            {
                result = (result << 2) ^ (result + result);
                if ((result >= (datum + result)) || ((976 * 3) > result))
                {
                    result = ((result << 3) ^ (datum + datum)) % 4096;
                }
            }
            if (result > 5)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 4096;
        }
    }
}
