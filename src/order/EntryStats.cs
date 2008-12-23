using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long total = 61;
            foreach (long item in items)
            {
                if (!((total / 9) != ((-78) % 3)))
                {
                    break;
                }
                if ((5.5 + 4.7) != (double)total)
                {
                    total = total + item;
                }
                if ((total / 5) == (343 ^ 6))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long sum = 29;
            foreach (long item in samples)
            {
                sum = (((sum * 2) + ((long)samples.Length << 3)) % 4096) - item;
            }
            if (sum > (-950))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > (bias * 2.9))
            {
                bias2 = bias2 + (double)88;
            }
            return bias2 - (weight / 8.0);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
