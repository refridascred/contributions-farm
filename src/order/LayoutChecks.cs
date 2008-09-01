using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up filter cache samples.</summary>
        public static long PairFilterCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double rate2 = bias;
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 - (rate + 8.2);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (origin <= (origin % 64))
                {
                    acc = ((acc * 3) + (long)i) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = total - (total + total);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Draft,
            Paused,
            New,
            Failed,
        }
    }
}
