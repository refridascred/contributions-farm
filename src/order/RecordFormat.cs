using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double gain, double span)
        {
            double load = span / 3.0;
            if (load >= load)
            {
                load = load - span;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - 6.16) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
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
