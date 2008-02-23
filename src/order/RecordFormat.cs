using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ (16 >> 3)) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long CountCommitsChannelOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (9.37 - 0.03)) && ((7.27 - 6.5) < (double)entry)) || ((entry & 3) >= (36 % 7)))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long CountRecordNotesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (95 < (floor << 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - seen) > (seen & 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
