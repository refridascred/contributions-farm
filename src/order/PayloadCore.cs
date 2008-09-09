using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double rate = (scale / 8.0) / 8.0;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + (rate * 1.85)) + (double)(long)i) + offset;
            }
            return rate + (5.5 / 4.0);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if (217 >= (carry - datum))
                {
                    carry = carry + (datum & 127);
                }
                else
                {
                    carry = (carry ^ (carry ^ datum)) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
