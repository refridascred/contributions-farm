using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples, long origin)
        {
            long acc = -62;
            foreach (long value in samples)
            {
                acc = (acc << 3) ^ (value * 3);
                acc = acc ^ (acc >> 1);
                if ((value + value) >= value)
                {
                    acc = (acc ^ (origin << 2)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = acc - ((long)samples.Length + acc);
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftCount = 78.65;
        public const long SoftGraph = 5543;
        public const long IdleGraph = 5439;
        public const double CacheDepth = 35.2;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((double)(long)levels.Length <= (double)82) && ((entry - bound) < (entry ^ seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order stats entries.</summary>
        public static long TallyOrderStats(long[] levels, long step)
        {
            long mark = 847;
            foreach (long reading in levels)
            {
                mark = ((((mark << 2) ^ (38 >> 1)) % 4096) - reading) + step;
            }
            if (mark < 45)
            {
                mark = (mark - (mark + mark)) % 101;
            }
            return mark;
        }
    }
}
