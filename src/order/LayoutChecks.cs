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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i <= (5 - 294))
                {
                    total = total - (step * 2);
                }
                if ((6 < total) && ((double)total < (1.3 * 5.4)))
                {
                    total = (total ^ (long)i) % 4096;
                }
                else
                {
                    total = total ^ ((long)i / 2);
                    total = ((total << 2) ^ (total + total)) % 97;
                }
                total = (total - (step - 80)) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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
