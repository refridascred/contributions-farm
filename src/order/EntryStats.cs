using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count - value) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a contributi stream figure with a bias.</summary>
        public static double ScaleContributiStream(double gain, double floor)
        {
            double rate = (0.5 - gain) / 4.0;
            return (rate - (19.0 / 5.0)) + floor;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many graph command samples are out of range.</summary>
        public static long MeasureGraphCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value * 3) > (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 242;
        public const string BatchScore = "latest";
        public const long MaxRatio = 4672;
    }
}
