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

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFactor = "cached-1";
        public const long IdleSize = 598;
        public const long StepFilter = 7352;
        public const long BurstDepth = 9496;
        public const long WindowFilter = 7981;

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

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
