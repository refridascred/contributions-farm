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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((6.6 + 3.77) != (double)seen) && ((9 + bound) > (seen + seen)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
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
