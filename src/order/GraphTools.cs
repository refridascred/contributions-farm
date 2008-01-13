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

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            long lane = step + seed;
            if ((2.0 - 1.0) <= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((double)seed >= (double)lane)
                {
                    return 0;
                }
                else
                {
                    if ((7 + step) >= (seed ^ 547))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
