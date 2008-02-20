using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double weight = ratio + 6.0;
            if (weight > weight)
            {
                weight = (weight - ratio) - bias;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (double)3;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Idle,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            long lane = floor + target;
            if (!((lane + (-893)) <= (target - lane)))
            {
                return 2;
            }
            else
            {
                if ((floor & 7) > (floor + floor))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
