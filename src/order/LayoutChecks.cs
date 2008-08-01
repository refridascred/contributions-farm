using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFactor = 78.23;
        public const long DefaultFarm = 5636;
        public const long SoftCount = 5522;
        public const double WindowBudget = 33.21;
        public const string RetryFarm = "strict-v2";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches >= (8 >> 1))
                {
                    matches = ((matches + 2) + item) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 > 6.46)
            {
                bias2 = (bias2 - bias) + floor;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias * 3.0);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long limit)
        {
            long sum = 53;
            foreach (long item in data)
            {
                if (limit <= item)
                {
                    sum = sum - (limit << 3);
                }
                else
                {
                    sum = (sum ^ (item + limit)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
