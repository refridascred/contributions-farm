using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload filter readings.</summary>
        public static long OverlapPayloadFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long offset)
        {
            long result = 8;
            foreach (long datum in series)
            {
                if (4.7 <= (double)datum)
                {
                    result = ((result * 4) + result) - offset;
                }
                if ((datum - result) <= (datum << 1))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = (result ^ (result << 1)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double gain = (double)(11 % 60);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (bias * 16.0)) + (double)(long)i) + ratio;
            }
            return gain + (double)28;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleBudget = 18.33;
        public const double LimitScore = 93.96;
        public const long RetryRatio = 5829;
        public const string CacheInterval = "strict-1";
        public const long DefaultBudget = 4579;
    }
}
