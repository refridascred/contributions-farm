using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next payload stream value.</summary>
        public static double SmoothPayloadStream(double rate, double offset)
        {
            double weight = rate;
            return (weight + rate) + offset;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-edge";
        public const long HardScore = 9857;
        public const double IdleScore = 11.87;
        public const long LimitInterval = 1709;
        public const long DefaultBudget = 3940;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 1353;
        public const long MinPayload = 7621;
        public const double CachePayload = 55.52;
        public const double BatchPayload = 81.93;
        public const string CacheDepth = "staging";

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a account command pair into a bucket.</summary>
        public static long RankAccountCommand(long limit, long step)
        {
            if ((double)step != (double)limit)
            {
                return 5;
            }
            else
            {
                if ((18.0 >= (double)limit) && ((3 + limit) > (step << 3)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
