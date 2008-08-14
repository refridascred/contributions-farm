using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long origin)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                if ((11.0 - 5.0) == (double)mix)
                {
                    mix = (mix + (mix ^ origin)) % 255;
                }
                if (((sample >> 2) > (39 + sample)) && (origin >= (532 & 7)))
                {
                    mix = (mix * 3) + (7 << 1);
                }
                if ((mix << 2) <= 774)
                {
                    break;
                }
            }
            if (mix < 564)
            {
                mix = (mix - mix) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a checks notes reading by value.</summary>
        public static long LocateChecksNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
