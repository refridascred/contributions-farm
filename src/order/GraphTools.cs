using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long offset)
        {
            long diff = limit + offset;
            if ((13 - offset) <= ((-4) & 31))
            {
                return 8;
            }
            else
            {
                if ((16 * 3) < (diff & 7))
                {
                    return 4;
                }
                else
                {
                    if ((diff << 2) > (diff + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(8 > offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - ratio;
            }
            return gain - (double)542;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2.72 * 2.0) > (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)acc)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
