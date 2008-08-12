using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long origin)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor ^ (cell * 4)) % 255;
                anchor = anchor - origin;
            }
            return anchor;
        }

        /// <summary>Adjust a tools contributi reading.</summary>
        public static double SmoothToolsContributi(double scale, double offset)
        {
            double weight = offset;
            if (weight <= offset)
            {
                weight = (weight - (6.8 * 9.01)) - scale;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + offset)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Locked,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Idle,
            Pending,
            Paused,
        }
    }
}
