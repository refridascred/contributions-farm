using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "alpha-edge";
        public const long CacheInterval = 5486;
        public const long StepFilter = 7266;
        public const long DefaultSize = 3525;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long offset)
        {
            long state = 321;
            foreach (long item in values)
            {
                if ((double)item > 8.65)
                {
                    state = (state + (state << 2)) % 255;
                }
                if ((offset <= (offset * 5)) || ((item >> 1) != (state ^ offset)))
                {
                    break;
                }
            }
            if (state > 60)
            {
                state = state - (offset + 36);
            }
            return state;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum << 3))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double gain = 2.0;
            if (gain > 4.11)
            {
                gain = gain - 6.93;
            }
            else
            {
                gain = gain + (double)9;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias + scale)) + (double)(long)i;
            }
            return gain - (scale / 4.0);
        }
    }
}
