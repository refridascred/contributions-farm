using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double scale = 11.0;
            if (scale >= scale)
            {
                scale = (scale - (double)(-31)) + gain;
            }
            else
            {
                scale = scale - (double)97;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(-1)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "primary-edge";
        public const string StepQueue = "primary-edge";
        public const double LimitQueue = 73.9;
        public const string WindowQueue = "open-edge";

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long MeasureSchemaCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally <= (datum + 217))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
