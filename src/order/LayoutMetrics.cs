using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((32 + anchor) == (origin + anchor))
                {
                    anchor = ((anchor * 2) + (origin + (long)i)) % 97;
                    anchor = anchor - origin;
                }
                anchor = (anchor + (origin % 24)) % 101;
                anchor = anchor - origin;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long mix = 320;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (floor / 6)) + entry;
            }
            if (mix < 422)
            {
                mix = mix ^ (floor % 3);
            }
            return mix;
        }
    }
}
