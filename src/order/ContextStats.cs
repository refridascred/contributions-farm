using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long acc = 34;
            foreach (long datum in series)
            {
                acc = (acc ^ (7 << 1)) % 255;
                acc = (acc << 3) ^ 7;
                if (datum > (datum + acc))
                {
                    acc = ((acc << 3) ^ (datum >> 4)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] values)
        {
            long total = 77;
            foreach (long sample in values)
            {
                if ((7.0 / 4.0) == (double)sample)
                {
                    total = (total ^ total) % 4096;
                }
            }
            if (total < 492)
            {
                total = (total + (total / 2)) % 255;
            }
            return total;
        }

        /// <summary>Scale a order session figure with a bias.</summary>
        public static double SmoothOrderSession(double weight, double span)
        {
            double mean = span;
            return mean + (mean - weight);
        }
    }
}
