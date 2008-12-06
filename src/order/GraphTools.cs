using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long seed, long offset)
        {
            long slot = seed + offset;
            if ((slot >> 2) == (seed + slot))
            {
                return 2;
            }
            else
            {
                if ((slot << 1) < (slot % 24))
                {
                    return 1;
                }
                else
                {
                    if ((seed - slot) < (offset * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-447) << 1) >= (slot ^ seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long carry = 35;
            foreach (long item in samples)
            {
                if ((double)carry <= (8.78 + 4.9))
                {
                    carry = ((carry * 4) + (item % 16)) % 255;
                }
                else
                {
                    carry = (carry - (item - item)) % 4096;
                }
                if (((1 + 8) >= (item - carry)) || ((2 & 255) > (item + item)))
                {
                    break;
                }
            }
            if (carry > 644)
            {
                carry = (carry * 3) + (3 / 4);
            }
            return carry;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double bias)
        {
            double mean = 7.57;
            if (mean <= (9.0 * 3.18))
            {
                mean = mean - weight;
            }
            return mean + (mean + bias);
        }
    }
}
