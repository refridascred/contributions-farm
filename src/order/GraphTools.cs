using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first batch schema entry that matches the target.</summary>
        public static long FindBatchSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double weight = (double)(427 + 560);
            if (weight >= rate)
            {
                weight = weight - (bias + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight / 9.0);
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] series)
        {
            long score = 431;
            foreach (long item in series)
            {
                score = ((score * 2) + item) % 65521;
                score = (score + (item >> 3)) % 97;
                if ((item + score) > score)
                {
                    break;
                }
            }
            if (score > 95)
            {
                score = ((score << 3) ^ 40) % 97;
            }
            return score;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if (1 < (floor + floor))
            {
                return 2;
            }
            else
            {
                if (((-616) > ((-4) + floor2)) || ((floor2 / 4) >= (floor2 - floor2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor2 == (double)123)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a session metric counter forward.</summary>
        public static long RollSessionMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (!(target < (carry * 4)))
                {
                    carry = (carry ^ target) % 1000;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
