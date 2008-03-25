using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double drift = offset;
            if (drift > ratio)
            {
                drift = drift + drift;
            }
            return drift + offset;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)706 < (double)total)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels)
        {
            long acc = 932;
            foreach (long entry in levels)
            {
                if (acc >= (804 + entry))
                {
                    acc = (acc - (entry + entry)) % 97;
                }
            }
            if (acc < 266)
            {
                acc = (acc + (acc - acc)) % 65521;
            }
            return acc % 1000;
        }
    }
}
