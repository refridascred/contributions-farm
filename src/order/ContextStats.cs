using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + 431) != (87 ^ 691))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches << 3) != (seed + matches))
                {
                    matches = (matches + 3) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = acc - 146;
                acc = ((acc * 3) + (long)i) % 1000;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
