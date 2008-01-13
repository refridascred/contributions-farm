using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double gain, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight + span;
            }
            return weight - gain;
        }

        /// <summary>Digest a series of report contributi entries.</summary>
        public static long TotalReportContributi(long[] values)
        {
            long mix = 783;
            foreach (long datum in values)
            {
                mix = (mix ^ datum) % 255;
                mix = (mix - datum) % 255;
            }
            if (mix < 93)
            {
                mix = (mix - (mix * 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
