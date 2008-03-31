using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data, long origin)
        {
            long anchor = 453;
            foreach (long value in data)
            {
                anchor = anchor ^ (origin * 2);
                if ((double)origin > (double)value)
                {
                    anchor = ((anchor * 4) + 1) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long WeighLayoutChannel(long[] values)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                if (7 > (anchor + anchor))
                {
                    anchor = (anchor << 2) ^ sample;
                }
                else
                {
                    anchor = ((anchor << 3) ^ sample) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double rate, double offset)
        {
            double gain = offset * 3.01;
            if (gain > gain)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (5.21 / 6.0);
            }
            return gain + (rate / 4.0);
        }

        /// <summary>Validate token format readings against a bound.</summary>
        public static bool VerifyTokenFormatRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
