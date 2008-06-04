using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many editor buffer samples are out of range.</summary>
        public static long CountEditorBufferMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9 ^ tally) == (700 + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item / 3) >= (hits + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache token entries.</summary>
        public static long TallyCacheToken(long[] samples)
        {
            long anchor = 8;
            foreach (long entry in samples)
            {
                if ((anchor * 3) == (anchor ^ entry))
                {
                    anchor = ((anchor << 3) ^ (anchor & 127)) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor & 31)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 + 16.0) - (double)(long)i) + gain;
            }
            return gain2 + (double)750;
        }
    }
}
