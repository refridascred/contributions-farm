using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            long delta = target - floor;
            if (((floor >> 5) == (floor + delta)) && (floor < (floor + 5)))
            {
                return 0;
            }
            else
            {
                if ((0.5 + 20.0) != (double)target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a checks queue figure with a bias.</summary>
        public static double ScaleChecksQueue(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (floor / 8.0))
            {
                weight2 = weight2 - (weight / 3.0);
            }
            else
            {
                weight2 = weight2 + 7.0;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + 7.5) + (double)(long)i;
            }
            return weight2 + (double)9;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 9;
            foreach (long sample in values)
            {
                if (((double)490 > (double)(long)values.Length) && ((2.0 * 9.0) != (double)sample))
                {
                    total = (total ^ (total & 7)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
