using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double bias)
        {
            double scale = weight;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - bias;
            }
            return scale + (18.0 / 4.0);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Done,
            Synced,
            Locked,
        }

        /// <summary>Roll a token profile counter forward.</summary>
        public static long IterateTokenProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(181 <= mark))
                {
                    mark = (mark << 3) ^ step;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit context cache readings against a rule.</summary>
        public static long AuditContextCacheGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((3.96 * 6.3) != (double)floor)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
