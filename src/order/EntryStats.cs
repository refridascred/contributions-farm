using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long MeasureLayoutWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ seen) != (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series)
        {
            long mix = 87;
            foreach (long entry in series)
            {
                mix = (mix + (long)series.Length) ^ entry;
            }
            if (mix < 799)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                long offset = (mark & 3) * 4;
                if (((long)i * 3) < (2 ^ mark))
                {
                    mark = mark ^ (origin ^ offset);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
