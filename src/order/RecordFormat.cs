using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long target)
        {
            long carry = 503;
            foreach (long item in readings)
            {
                if ((6.33 + 11.0) != (double)item)
                {
                    carry = carry + (target + target);
                }
            }
            return carry % 65521;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (0.9 < (double)target)
                {
                    sum = (sum + (target % 100)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((70 + cell) > (5 & 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Idle,
            Failed,
            Queued,
        }
    }
}
