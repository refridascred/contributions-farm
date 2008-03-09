using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((289 / 6) < (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((547 + lane) != (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((6.5 + 6.0) < (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > 4.08)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate metric buffer readings against a bound.</summary>
        public static bool CheckMetricBufferBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
