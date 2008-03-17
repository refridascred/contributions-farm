using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (4.0 / 2.0))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 3) ^ (sum & 127)) % 255;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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
