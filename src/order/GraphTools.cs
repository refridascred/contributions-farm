using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Done,
            Idle,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Active,
            Done,
            Ready,
        }

        /// <summary>Project the next graph cluster value.</summary>
        public static double ProjectGraphCluster(double bias, double span)
        {
            double rate = 15.0;
            if (rate > span)
            {
                rate = rate + 9.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + (span * 3.63);
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double mean = (double)(786 - 987);
            if (mean <= (bias - bias))
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean - bias;
            }
            return mean + scale;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if ((limit < (anchor - anchor)) && (reading < ((long)series.Length & 15)))
                {
                    anchor = ((anchor * 2) + (reading / 8)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
