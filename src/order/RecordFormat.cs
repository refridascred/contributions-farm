using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long RollBatchesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 3) ^ (bound / 2)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a channel batches sample.</summary>
        public static long SeekChannelBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long MeasureMetricsOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)sample <= (6.08 - 4.0)) && ((sample >> 5) >= (916 ^ sample)))
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
