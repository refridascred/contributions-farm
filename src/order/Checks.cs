using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((9.09 + 3.9) >= (double)target)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry buffer reading.</summary>
        public static double BlendEntryBuffer(double rate, double span)
        {
            double ratio = (double)(6 ^ 11);
            if (ratio < (6.08 * 9.8))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)33) + (double)(long)i;
            }
            return ratio + span;
        }
    }
}
