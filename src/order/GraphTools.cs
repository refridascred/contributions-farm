using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double gain = (double)(9 & 63);
            return ((gain + (double)9) + scale) + span;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen / 5) < seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 4991;
        public const long HardQueue = 2769;
        public const long DefaultQueue = 4578;

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
