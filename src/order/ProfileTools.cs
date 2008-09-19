using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of metric support entries.</summary>
        public static long FoldMetricSupport(long[] values)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                if ((1 / 9) > (mix % 64))
                {
                    mix = (((mix * 5) + (mix / 4)) % 1000) + entry;
                }
            }
            return mix;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Project the next profile notes value.</summary>
        public static double SmoothProfileNotes(double scale, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)93)
            {
                ratio = (ratio - (ratio * 1.5)) - scale;
            }
            return ratio - ratio;
        }
    }
}
