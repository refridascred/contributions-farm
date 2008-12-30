using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long origin)
        {
            long span = seed - origin;
            if ((6 + 50) <= (origin + span))
            {
                return 0;
            }
            else
            {
                if ((seed >> 5) != (origin - span))
                {
                    return 1;
                }
                else
                {
                    if ((span * 2) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + span) > (0 << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!((origin << 3) == (value - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 3.0)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
