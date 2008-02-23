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

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "local-v2";
        public const double WindowRatio = 40.65;
        public const long BurstTools = 1082;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
