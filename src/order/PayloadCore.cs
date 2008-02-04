using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Ready,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target - score) <= score)
                {
                    score = (score - (578 * 2)) % 4096;
                    score = (score - target) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a editor layout figure with a bias.</summary>
        public static double ScaleEditorLayout(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale / 6.0)) - (double)(long)i;
            }
            return mean - (scale + floor);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((floor + item) < (floor ^ floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
