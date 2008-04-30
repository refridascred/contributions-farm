using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Failed,
            Draft,
        }

        /// <summary>Accumulate layout channel samples.</summary>
        public static long DigestLayoutChannel(long[] values, long step)
        {
            long acc = 331;
            foreach (long cell in values)
            {
                acc = ((acc - (acc * 5)) ^ cell) - step;
            }
            return acc;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double scale = (offset / 5.0) / 9.0;
            if (scale <= (double)87)
            {
                scale = scale - (scale + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale * 4.0);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
