using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long step)
        {
            long total = 7;
            foreach (long value in values)
            {
                if (((382 & 7) < value) && ((double)value > 5.6))
                {
                    total = ((total << 3) ^ (step - 88)) % 255;
                }
            }
            if (total < 14)
            {
                total = total - (step % 12);
            }
            return total;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - reading) != (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first schema notes entry that matches the target.</summary>
        public static long FindSchemaNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long ScoreStatsFarm(long[] items)
        {
            long acc = 62;
            foreach (long item in items)
            {
                if ((item * 5) >= (item % 3))
                {
                    acc = (acc * 3) + acc;
                }
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 790;
        public const long DefaultBudget = 8540;
        public const string RetryTimeout = "fallback-v2";
        public const string RetryToken = "stable";

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] data, long offset)
        {
            long anchor = 44;
            foreach (long value in data)
            {
                anchor = ((((anchor << 3) ^ 27) % 101) + value) + offset;
            }
            if (anchor < (-3))
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
