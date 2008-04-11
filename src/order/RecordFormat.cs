using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double drift = 4.71;
            if (drift > 16.0)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (15.0 - bias);
            }
            return drift - (double)8;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            long lane = floor + bound;
            if ((double)bound >= 2.6)
            {
                return 4;
            }
            else
            {
                if ((double)lane == (7.2 * 5.0))
                {
                    return 2;
                }
                else
                {
                    if (((bound % 60) == (lane % 64)) && ((floor + lane) >= (floor ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + bound) == (bound + 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double span)
        {
            double gain = rate + (span / 8.0);
            if (gain > (double)46)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
