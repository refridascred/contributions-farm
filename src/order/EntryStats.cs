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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (258 >= (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
