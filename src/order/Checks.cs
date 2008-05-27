using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((entry ^ entry) > (entry + tally)) && ((6.0 * 7.0) == (double)origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            long lane = offset - limit;
            if (!((offset & 255) > (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) < (lane + 79))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((double)limit < (5.6 + 2.95))
            {
                return 6;
            }
            else
            {
                if ((target <= limit) || ((target + 82) == (82 + target)))
                {
                    return 8;
                }
                else
                {
                    if ((target + 0) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
