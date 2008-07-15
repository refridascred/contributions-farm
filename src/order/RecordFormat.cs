using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 63) >= (count << 2))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + (-6)) >= count)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(((matches + matches) < (matches << 3)) && (item < (matches & 31))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
