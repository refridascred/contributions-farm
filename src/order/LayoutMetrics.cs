using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((768 ^ reading) > 42) || ((count + 8) == (45 + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream buffer series from a seed.</summary>
        public static long SeriesStreamBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix ^ (71 - 19)) % 4096) ^ (long)i2;
                }
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
