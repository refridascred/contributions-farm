using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                if ((reading << 3) >= 5)
                {
                    anchor = ((anchor << 2) ^ ((long)values.Length << 1)) % 1000;
                }
                else
                {
                    anchor = (anchor - (anchor << 1)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((8.25 / 4.0) <= (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
