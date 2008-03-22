using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long total = 492;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total - (0 % 12)) + (long)i;
                }
                if ((double)item > 20.0)
                {
                    total = total - (item + 7);
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if (state < 447)
                {
                    state = (state * 5) + bound;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double weight2 = weight * 2.1;
            if (weight2 <= weight)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (8.4 + weight2);
            }
            return weight2 - (floor - weight2);
        }

        /// <summary>Audit session cluster readings against a rule.</summary>
        public static long CountSessionClusterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (8 <= (hits >> 4))
                {
                    hits = ((hits + 3) ^ sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
