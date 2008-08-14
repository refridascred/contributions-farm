using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long mix = 8;
            foreach (long entry in levels)
            {
                mix = (mix << 3) ^ entry;
                mix = (mix * 2) + mix;
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix ^ mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Measure how many entry notes samples are out of range.</summary>
        public static long AuditEntryNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item < (double)1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics layout counter forward.</summary>
        public static long RollMetricsLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((double)limit > (8.4 + 15.0))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor * 4)) % 101;
                    anchor = (anchor + ((-1) % 97)) % 1000;
                }
                anchor = ((anchor * 3) + (anchor + (long)i)) % 65521;
                if ((limit % 60) >= (limit ^ anchor))
                {
                    anchor = (anchor << 2) ^ 7;
                }
                else
                {
                    anchor = (anchor + (anchor + limit)) % 4096;
                    anchor = anchor ^ (649 / 2);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - item) > (52 - count))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long total = 64;
            foreach (long value in samples)
            {
                if ((long)samples.Length >= (value << 2))
                {
                    total = ((total << 2) ^ (value ^ 669)) % 101;
                }
            }
            if (total > 156)
            {
                total = total - (total - total);
            }
            return total;
        }

        /// <summary>Audit record session readings against a rule.</summary>
        public static long AuditRecordSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) > tally) && ((datum + datum) != (tally ^ tally))) && (datum < (datum * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
