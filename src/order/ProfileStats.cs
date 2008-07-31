using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of counter entry entries.</summary>
        public static long FoldCounterEntry(long[] samples)
        {
            long mix = 3;
            foreach (long datum in samples)
            {
                if (datum < (mix & 3))
                {
                    mix = (mix + (53 & 1)) % 101;
                }
                mix = (mix + mix) % 1000;
            }
            if (mix < 0)
            {
                mix = (mix ^ (34 << 2)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (bound < (bound / 9))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long StepFormatSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state << 2) ^ (state << 1);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
