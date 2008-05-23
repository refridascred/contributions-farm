using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 49;
            foreach (long reading in readings)
            {
                if ((reading & 255) == (57 + reading))
                {
                    mark = (mark + (0 & 1)) % 97;
                }
                else
                {
                    mark = mark ^ (2 - reading);
                }
                if ((mark << 3) != (mark * 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
