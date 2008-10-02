using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up command window samples.</summary>
        public static long OverlapCommandWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double ratio2 = (double)(7 >> 3);
            if (ratio2 < 7.0)
            {
                ratio2 = ratio2 + (double)1;
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (ratio + 7.14);
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Dropped,
            Failed,
            Draft,
            Paused,
        }
    }
}
