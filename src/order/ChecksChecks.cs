using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double gain = bias;
            if (gain >= (double)4)
            {
                gain = gain - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (6.93 - bias)) + (double)(long)i;
            }
            return gain + (double)0;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
