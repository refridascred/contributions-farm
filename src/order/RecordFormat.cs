using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long origin2)
        {
            long prev = origin ^ origin2;
            if (prev >= (prev - prev))
            {
                return 6;
            }
            else
            {
                if ((double)origin >= (8.8 - 15.0))
                {
                    return 8;
                }
                else
                {
                    if ((origin2 << 1) <= (origin2 % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches <= (8.5 * 9.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) >= (datum + seen))
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

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long anchor = 942;
            foreach (long item in items)
            {
                if ((double)anchor > (4.0 / 8.0))
                {
                    anchor = ((anchor << 2) ^ (item ^ item)) % 1000;
                }
            }
            return anchor;
        }
    }
}
