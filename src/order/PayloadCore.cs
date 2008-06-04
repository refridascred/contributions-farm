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

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
