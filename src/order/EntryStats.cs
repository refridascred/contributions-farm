using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate format context readings against a bound.</summary>
        public static bool ValidateFormatContextRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count > (cell * 5))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long mark = 5;
            foreach (long datum in readings)
            {
                mark = mark ^ (mark ^ datum);
                mark = mark - mark;
            }
            return mark;
        }
    }
}
