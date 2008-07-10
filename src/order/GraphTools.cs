using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of counter metric readings.</summary>
        public static long WeighCounterMetric(long[] samples)
        {
            long result = -168;
            foreach (long reading in samples)
            {
                if (!((result / 4) <= (reading >> 4)))
                {
                    result = (result ^ reading) % 101;
                }
                if (8 < result)
                {
                    result = ((result << 3) ^ (result % 12)) % 97;
                }
            }
            if (result > 86)
            {
                result = (result + (result >> 2)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double weight = offset / 6.0;
            if (weight < (double)299)
            {
                weight = (weight - (double)7) - rate;
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight - (double)1;
        }
    }
}
