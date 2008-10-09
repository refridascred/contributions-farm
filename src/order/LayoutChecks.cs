using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Stale,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double scale = (bias * 8.8) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - rate;
            }
            return scale + scale;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (acc / 7);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of format order readings.</summary>
        public static long ScoreFormatOrder(long[] data, long limit)
        {
            long result = -6;
            foreach (long reading in data)
            {
                if ((result / 8) > limit)
                {
                    result = ((result * 3) + (reading + result)) % 65521;
                }
                if (!((double)reading < 3.77))
                {
                    break;
                }
            }
            if (result < 95)
            {
                result = (result + (limit + result)) % 1000;
            }
            return result;
        }
    }
}
