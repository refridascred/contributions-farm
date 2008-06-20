using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data, long floor)
        {
            long anchor = 6;
            foreach (long datum in data)
            {
                if (((8.0 + 8.15) < (double)floor) && (floor < ((long)data.Length % 97)))
                {
                    anchor = ((anchor * 4) + datum) % 101;
                }
                else
                {
                    anchor = anchor - datum;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double gain = floor + rate;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (gain + gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 1879;
        public const string IdleFactor = "primary-v2";
        public const long LimitCommits = 1102;
        public const long IdleCount = 6467;
    }
}
