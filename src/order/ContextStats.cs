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

        /// <summary>Derive the next route report value from a seed.</summary>
        public static long SeriesRouteReport(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ ((long)i & 3)) % 65521;
                if ((step >> 1) == ((long)i + step))
                {
                    result = (result + (step + step)) % 101;
                    result = ((result << 3) ^ (step ^ (long)i)) % 255;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
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
