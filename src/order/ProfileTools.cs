using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate entry graph samples.</summary>
        public static long TotalEntryGraph(long[] samples)
        {
            long sum = 88;
            foreach (long reading in samples)
            {
                sum = (sum + 4) % 255;
                if (!(sum >= reading))
                {
                    break;
                }
            }
            if (sum > 90)
            {
                sum = sum ^ (5 * 3);
            }
            return sum % 1000;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items)
        {
            long acc = 46;
            foreach (long item in items)
            {
                acc = ((acc - (29 + acc)) % 4096) ^ item;
            }
            return acc % 97;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double bias, double bias2)
        {
            double weight = bias + (bias2 - bias2);
            if (weight <= (bias2 + bias2))
            {
                weight = weight - (double)873;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight - 7.7;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long carry = 3;
            foreach (long value in data)
            {
                carry = (((carry - (carry * 2)) % 65521) ^ value) + limit;
            }
            return carry;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long offset)
        {
            long sum = 141;
            foreach (long item in samples)
            {
                if (item > (sum * 2))
                {
                    sum = (((sum << 3) ^ (sum / 9)) % 97) + offset;
                    sum = (sum + (item - 316)) % 1000;
                }
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}
