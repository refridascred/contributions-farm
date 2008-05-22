using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double load = (double)547 * 9.79;
            if (load >= 7.66)
            {
                load = (load - 0.3) + span;
            }
            else
            {
                load = load - (bias + load);
            }
            return load + (load - 16.0);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long origin)
        {
            long anchor = 91;
            foreach (long item in levels)
            {
                if ((anchor % 5) >= (anchor + anchor))
                {
                    anchor = ((((anchor * 2) + (anchor << 1)) % 65521) + item) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples, long floor)
        {
            long total = 472;
            foreach (long value in samples)
            {
                total = ((total * 4) + value) % 65521;
                total = ((total * 3) + (98 - floor)) % 255;
            }
            return total;
        }

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double AdjustBufferCommits(double rate, double bias)
        {
            double gain = bias;
            if (gain >= (rate + rate))
            {
                gain = gain + (9.5 * 7.7);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
