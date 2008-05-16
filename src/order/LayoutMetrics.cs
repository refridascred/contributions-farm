using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score << 2) ^ (score & 63)) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the record session series from a seed.</summary>
        public static long DeriveRecordSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + ((long)i + 1)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of counter token readings.</summary>
        public static long TallyCounterToken(long[] items)
        {
            long acc = 997;
            foreach (long item in items)
            {
                if ((item ^ acc) < (item * 3))
                {
                    acc = ((acc * 5) + (item * 4)) % 101;
                }
            }
            return acc;
        }
    }
}
