using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long mix = 338;
            foreach (long cell in levels)
            {
                mix = (mix ^ (cell & 63)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((684 % 5) < (long)series.Length)
                {
                    seen = ((seen + 1) + reading) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long offset)
        {
            long bound = target ^ offset;
            if ((offset + target) < (bound << 2))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) == (offset - offset))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
