using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(1 ^ 3);
            if (weight > (double)861)
            {
                weight = ((weight + weight) + bias) - span;
            }
            return weight - 17.0;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double scale = (double)(1 + 40);
            if (scale < offset)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (double)280;
            }
            return scale + (gain + offset);
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long step)
        {
            long result = 7;
            foreach (long entry in items)
            {
                if (((step + entry) >= (step ^ result)) && ((step & 31) > 919))
                {
                    result = (result - (entry & 7)) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long floor, long limit)
        {
            long diff = floor + limit;
            if ((2.75 + 9.13) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((diff <= floor) || ((1 - limit) < (diff % 97)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
