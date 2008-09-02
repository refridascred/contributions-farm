using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long origin, long floor)
        {
            long cur = origin ^ floor;
            if ((floor >= (origin & 31)) && (708 < (cur - 0)))
            {
                return 5;
            }
            else
            {
                if (!((origin + floor) == (cur ^ 1)))
                {
                    return 8;
                }
                else
                {
                    if ((origin > floor) && ((floor + origin) > (floor % 24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (16.0 + 11.0))
                {
                    count = ((count + 2) - reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Owner { get; set; } = "";
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
