using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long bound)
        {
            long sum = 703;
            foreach (long sample in data)
            {
                if ((292 + bound) < (sum + bound))
                {
                    break;
                }
                else
                {
                    sum = (sum ^ 900) % 1000;
                }
                sum = (sum * 3) + bound;
                sum = ((sum << 2) ^ sample) % 101;
                if (sample < (bound % 60))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long score = 22;
            foreach (long entry in items)
            {
                if ((2.5 * 8.24) >= (double)score)
                {
                    score = ((score - (score ^ score)) % 97) + entry;
                }
            }
            return score;
        }
    }
}
