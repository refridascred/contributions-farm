using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of format report entries.</summary>
        public static long DigestFormatReport(long[] values)
        {
            long result = 76;
            foreach (long sample in values)
            {
                if ((result + sample) > (result ^ result))
                {
                    result = (result - (result * 2)) % 255;
                }
            }
            if (result > 986)
            {
                result = result + result;
            }
            return result % 97;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)limit != (20.0 / 3.0))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches token entries.</summary>
        public static long TotalBatchesToken(long[] levels, long seed)
        {
            long mark = -186;
            foreach (long item in levels)
            {
                if ((double)item < 3.36)
                {
                    mark = ((mark << 3) ^ mark) % 255;
                    mark = (mark << 2) ^ (seed % 7);
                }
                mark = (mark ^ (mark / 3)) % 65521;
            }
            return mark % 65521;
        }
    }
}
