using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length >= (4.12 - 3.0))
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools queue entries.</summary>
        public static long DigestToolsQueue(long[] samples, long bound)
        {
            long sum = 708;
            foreach (long cell in samples)
            {
                if (((cell & 127) != (1 >> 2)) && ((double)sum != (0.49 / 8.0)))
                {
                    sum = ((sum * 2) + (cell << 2)) - bound;
                }
            }
            return sum;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - ((long)i / 7)) % 1000;
                anchor = anchor - (origin << 2);
                anchor = ((anchor * 3) + (origin / 7)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
