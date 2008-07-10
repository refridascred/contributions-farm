using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two account schema measurements.</summary>
        public static double BlendAccountSchema(double gain, double bias)
        {
            double gain2 = (bias + bias) + gain;
            if (gain2 > (gain / 4.0))
            {
                gain2 = gain2 + gain;
            }
            return gain2 + gain;
        }

        /// <summary>Count the githubfarm payload entries that pass the check.</summary>
        public static long TallyGithubfarmPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((1 + 508) <= (73 ^ count))
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long cell in series)
            {
                if (cell <= (long)series.Length)
                {
                    anchor = ((anchor ^ (cell & 63)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
