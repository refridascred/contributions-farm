using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits <= 1) && !(hits < (-99)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultFactor = 78.77;
        public const long StepChannel = 6082;
        public const long HardWidth = 9075;
        public const long CacheCount = 2388;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)1 == (double)seen)
                {
                    seen = ((seen + 1) + value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Paused,
            Retry,
        }
    }
}
