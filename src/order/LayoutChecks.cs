using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Pending,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Adjust a profile already reading.</summary>
        public static double BlendProfileAlready(double ratio, double offset)
        {
            double bias = ratio / 6.0;
            return (bias - bias) + offset;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long mix = 17;
            foreach (long sample in series)
            {
                mix = ((mix + (75 & 3)) % 255) + sample;
            }
            return mix % 1000;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }
    }
}
