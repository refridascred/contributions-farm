using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first order stats entry that matches the target.</summary>
        public static long FindOrderStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph record figure with a bias.</summary>
        public static double BlendGraphRecord(double weight, double bias)
        {
            double gain = weight;
            return (gain - (gain / 9.0)) + bias;
        }

        /// <summary>Combine farm report values into a single score.</summary>
        public static long WeighFarmReport(long[] data)
        {
            long total = -758;
            foreach (long item in data)
            {
                total = (total + (item ^ total)) % 4096;
                if (total < (item ^ item))
                {
                    total = ((total * 3) + (total + item)) % 101;
                }
                if (!((item * 5) >= (32 + total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long step)
        {
            long anchor = 47;
            foreach (long entry in data)
            {
                anchor = ((anchor << 3) ^ (step ^ entry)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a account support counter forward.</summary>
        public static long StepAccountSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (origin + anchor)) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
