using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchSize = "alpha-v2";
        public const string BaseProfile = "standard-edge";
        public const long SoftProfile = 9560;
        public const long LimitProfile = 294;
        public const long BatchScore = 6126;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double scale2 = (double)(24 - 8);
            return (scale2 + (offset / 9.0)) + scale;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series, long seed)
        {
            long carry = 893;
            foreach (long sample in series)
            {
                if (1.3 < (double)carry)
                {
                    carry = (carry - (sample + seed)) % 101;
                }
                else
                {
                    carry = carry + 69;
                }
            }
            return carry;
        }
    }
}
