using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 47.69;
        public const long BurstGraph = 6450;
        public const string MaxFactor = "strict-v2";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4 / 9) == (3 + (long)readings.Length))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels, long floor)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if ((floor - sample) == (floor ^ (-67)))
                {
                    sum = (sum - (floor % 2)) % 101;
                }
            }
            return sum;
        }
    }
}
