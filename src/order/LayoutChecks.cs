using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
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

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long limit)
        {
            long next = target ^ limit;
            if (((target + next) >= (target << 1)) && ((double)next > (14.0 * 2.72)))
            {
                return 1;
            }
            else
            {
                if (!((target % 12) < (limit + target)))
                {
                    return 2;
                }
                else
                {
                    if ((0.73 / 5.0) < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (target > (5 * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (bound < (998 + 86))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
