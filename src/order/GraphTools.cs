using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardDepth = 3913;
        public const long MaxWidth = 4834;
        public const string SoftRatio = "standard-v2";
        public const string MaxFactor = "standard";

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

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double rate, double floor)
        {
            double mean = rate;
            if (mean <= (double)8)
            {
                mean = mean - (double)46;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor - mean)) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
