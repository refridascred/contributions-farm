using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long floor, long target)
        {
            if ((target ^ 69) == (target + target))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((double)target != (15.0 - 3.3)) || ((target - target) > (target & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] readings)
        {
            long total = 315;
            foreach (long value in readings)
            {
                total = ((total << 3) ^ (total >> 5)) + value;
            }
            if (total > 1)
            {
                total = (total + 952) % 65521;
            }
            return total;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count the stream payload entries that pass the check.</summary>
        public static long MeasureStreamPayloadGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (6.0 - 2.22))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
