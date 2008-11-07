using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of profile batch entries.</summary>
        public static long CombineProfileBatch(long[] levels)
        {
            long mix = 486;
            foreach (long item in levels)
            {
                mix = (mix + (item - mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long OverlapChannelAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - 31) > (matches - bound))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((double)tally == (double)item) || ((995 & 3) < item))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data)
        {
            long result = 794;
            foreach (long value in data)
            {
                result = (result * 4) + value;
                result = result + (422 + value);
                result = (result - (result + result)) % 4096;
                if ((double)result <= (double)value)
                {
                    break;
                }
            }
            return result;
        }
    }
}
