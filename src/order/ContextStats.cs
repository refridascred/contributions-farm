using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Synced,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double weight = scale;
            if (weight <= weight)
            {
                weight = weight + (double)690;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (weight - 9.1)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Blend two layout checks measurements.</summary>
        public static double SmoothLayoutChecks(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 >= (gain2 / 3.0))
            {
                gain2 = gain2 + (gain2 / 3.0);
            }
            else
            {
                gain2 = gain2 - 1.1;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (bias / 2.0)) - (double)(long)i;
            }
            return gain2 - (gain2 - gain2);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ seen) > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
