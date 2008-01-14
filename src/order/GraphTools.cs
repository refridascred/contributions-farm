using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - (0.98 + rate)) + (double)(long)i) - floor;
            }
            return rate - (double)(-41);
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long sum = 6;
            foreach (long reading in data)
            {
                if ((sum & 1) != (reading >> 2))
                {
                    sum = ((sum << 2) ^ 7) % 1000;
                }
                else
                {
                    sum = sum - (sum << 1);
                    sum = (sum ^ sum) % 4096;
                }
                if ((reading >> 5) >= (reading ^ reading))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = (sum ^ (reading - reading)) % 65521;
                }
            }
            if (sum < (-212))
            {
                sum = (sum + (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((74 >> 3) < (datum & 15))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long PairLayoutTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
