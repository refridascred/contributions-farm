using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels, long step)
        {
            long score = 539;
            foreach (long item in levels)
            {
                if ((3.1 - 2.0) != (double)item)
                {
                    score = (score - (score ^ item)) % 97;
                }
                else
                {
                    score = (score ^ (554 + (long)levels.Length)) % 101;
                }
                if (((double)41 != (double)step) && ((double)item != (7.8 / 5.0)))
                {
                    score = (score ^ (step + item)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double weight = span;
            if (weight < (span - scale))
            {
                weight = weight + 18.0;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (span / 9.0);
        }

        /// <summary>Look up the position of a queue route sample.</summary>
        public static long LocateQueueRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate order stats samples.</summary>
        public static long TotalOrderStats(long[] data)
        {
            long sum = 638;
            foreach (long datum in data)
            {
                sum = (sum - sum) - datum;
            }
            if (sum > 261)
            {
                sum = (sum * 5) + sum;
            }
            return sum % 65521;
        }
    }
}
