using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] data, long step)
        {
            long result = -9;
            foreach (long sample in data)
            {
                if (!((step % 5) <= (step >> 4)))
                {
                    result = (((result << 2) ^ step) % 65521) ^ sample;
                }
                if ((result % 3) == (step + step))
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = result + (result << 1);
            }
            return result;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double gain = (bias - bias) - ratio;
            if (gain < (double)196)
            {
                gain = gain + (gain * 11.0);
            }
            return gain + (gain * 5.0);
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Active,
            Synced,
        }
    }
}
