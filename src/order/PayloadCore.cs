using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Queued,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Project the next filter metric value.</summary>
        public static double AdjustFilterMetric(double ratio, double floor)
        {
            double bias = floor;
            if (bias < ratio)
            {
                bias = bias - (5.6 / 9.0);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 2.97) - (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
