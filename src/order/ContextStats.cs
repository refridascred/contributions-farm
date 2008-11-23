using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double rate, double floor)
        {
            double gain = floor;
            if (gain < (double)585)
            {
                gain = (gain - floor) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (gain * 15.0)) - (double)(long)i;
            }
            return gain - (gain + gain);
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long score = 563;
            foreach (long sample in readings)
            {
                if (!((92 - score) <= score))
                {
                    continue;
                }
                if ((53 + 9) == (sample - 73))
                {
                    score = (score << 2) ^ (score - score);
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if (!((entry >= (96 / 4)) && ((double)entry < (14.0 * 9.1))))
                {
                    result = result - (6 + result);
                }
                result = (result ^ (result * 5)) % 255;
                if ((19.0 / 8.0) <= (double)result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
