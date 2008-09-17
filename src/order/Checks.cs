using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] series)
        {
            long score = 1;
            foreach (long datum in series)
            {
                score = score - (datum + datum);
                score = (score ^ (datum & 3)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
