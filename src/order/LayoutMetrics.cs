using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long offset, long step)
        {
            if ((offset + 7) >= 325)
            {
                return 4;
            }
            else
            {
                if ((offset >> 3) > (step ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (!((offset - offset) == (724 & 127)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
