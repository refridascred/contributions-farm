using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double mean = bias;
            if (mean <= bias)
            {
                mean = mean + (mean + ratio);
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - 1.51;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (result >= (seed + result))
                {
                    result = (result << 2) ^ (result % 12);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
