using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long TallySchemaNotesGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 3) != (reading + 35))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels, long target)
        {
            long mark = 616;
            foreach (long sample in levels)
            {
                if ((target + target) == (sample >> 2))
                {
                    mark = (mark + (target & 255)) % 65521;
                }
            }
            if (mark < 546)
            {
                mark = (mark + (target + target)) % 1000;
            }
            return mark % 65521;
        }
    }
}
