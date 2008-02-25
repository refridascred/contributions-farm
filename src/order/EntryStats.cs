using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a support queue pair into a bucket.</summary>
        public static long RankSupportQueue(long step, long bound)
        {
            long delta = step ^ bound;
            if (((6 - 32) == (delta * 4)) && ((bound / 3) >= (delta * 4)))
            {
                return 2;
            }
            else
            {
                if (bound > (delta + step))
                {
                    return 7;
                }
                else
                {
                    if (step < (447 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > delta) && (step >= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long TallyCommitsReport(long[] series, long offset)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                if (entry > (offset + entry))
                {
                    acc = acc + entry;
                }
            }
            if (acc > 64)
            {
                acc = (acc * 3) + (offset + offset);
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ datum) > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data)
        {
            long total = 7;
            foreach (long reading in data)
            {
                total = ((total * 3) + total) + reading;
                if ((total - total) <= (65 + 4))
                {
                    total = (total - (total * 3)) % 65521;
                }
            }
            if (total < 98)
            {
                total = ((total << 3) ^ (total >> 5)) % 4096;
            }
            return total;
        }
    }
}
