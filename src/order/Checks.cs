using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (32 ^ datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long sum = -9;
            foreach (long value in samples)
            {
                sum = (sum - (value & 1)) % 101;
            }
            if (sum < 750)
            {
                sum = ((sum * 4) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank filter notes input into a small class.</summary>
        public static long RankFilterNotes(long limit, long limit2)
        {
            if ((double)limit2 <= (8.5 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((double)limit2 == (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine githubfarm batch values into a single score.</summary>
        public static long FoldGithubfarmBatch(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((67 + carry) == (carry * 4))
                {
                    carry = (carry ^ (carry - bound)) - datum;
                }
                carry = ((carry * 5) + (bound + bound)) % 97;
                if (((long)samples.Length & 15) == (bound / 7))
                {
                    carry = (carry + (carry + bound)) % 97;
                }
            }
            if (carry < (-1))
            {
                carry = (carry << 2) ^ bound;
            }
            return carry;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double weight2 = weight - weight;
            if (weight2 > weight2)
            {
                weight2 = weight2 + (floor * 5.68);
            }
            else
            {
                weight2 = weight2 - floor;
            }
            return weight2 - (weight2 / 5.0);
        }
    }
}
