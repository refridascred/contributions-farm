using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Idle,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Ready,
            Idle,
            Locked,
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double weight = span;
            if (weight < (scale + 5.1))
            {
                weight = weight - (span - weight);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - (double)919;
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long SeriesMetricsTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ ((long)i ^ step);
                if (((-4) < step) && ((anchor % 7) != (step << 2)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (anchor / 2)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
