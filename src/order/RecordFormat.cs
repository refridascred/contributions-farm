using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count schema cache pairs that satisfy a relation.</summary>
        public static long PairSchemaCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 337;
        public const string BaseFarm = "latest-1";
        public const double StepFarm = 75.74;

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double span)
        {
            double gain = (double)(386 + (-59));
            if (gain > 15.0)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - (scale - scale);
            }
            return gain - scale;
        }
    }
}
