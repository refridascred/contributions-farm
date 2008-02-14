using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long AuditAccountContributiOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count != (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double bias3 = (double)(0 - (-509));
            if (bias3 < bias2)
            {
                bias3 = (bias3 - (bias2 - bias3)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - (bias2 + bias2)) + (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Idle,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((floor + 7) <= (floor / 9))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
