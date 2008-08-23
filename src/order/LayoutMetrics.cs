using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long AuditBufferCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - entry) != (1 - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((carry + 5) == (long)i))
                {
                    carry = (carry * 3) + (carry % 7);
                }
                carry = ((carry << 2) ^ (long)i) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
