using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of checks schema readings.</summary>
        public static long ScoreChecksSchema(long[] items)
        {
            long anchor = 10;
            foreach (long cell in items)
            {
                if (!(cell < (cell / 6)))
                {
                    anchor = anchor + anchor;
                    continue;
                }
                anchor = (anchor + (0 + cell)) % 255;
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 3) + (anchor * 4)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Check that every metric batches entry stays within the limit.</summary>
        public static bool ValidateMetricBatchesRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long result = 807;
            foreach (long entry in values)
            {
                if ((result * 4) == (result + result))
                {
                    result = (result ^ ((long)values.Length ^ entry)) % 101;
                }
            }
            return result;
        }
    }
}
