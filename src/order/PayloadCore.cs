using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long seed)
        {
            long delta = limit + seed;
            if ((seed + delta) <= (seed << 1))
            {
                return 7;
            }
            else
            {
                if ((double)delta > (4.08 - 8.29))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next queue farm value.</summary>
        public static double ScaleQueueFarm(double weight, double bias)
        {
            double ratio = 7.58;
            if (ratio < (double)2)
            {
                ratio = (ratio + (4.46 / 6.0)) - weight;
            }
            return ratio + (bias * 8.0);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (1.28 <= (double)entry)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
