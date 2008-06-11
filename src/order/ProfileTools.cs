using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the contributi profile entries that pass the check.</summary>
        public static long TallyContributiProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 3) == (count % 60))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            long edge = origin + floor;
            if (!((double)origin > (8.8 / 5.0)))
            {
                return 8;
            }
            else
            {
                if ((double)711 != (double)edge)
                {
                    return 4;
                }
                else
                {
                    if (!((edge << 3) < floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank batch queue input into a small class.</summary>
        public static long GradeBatchQueue(long target, long offset)
        {
            long step = target ^ offset;
            if ((double)90 >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((target / 2) > 3)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of report payload readings.</summary>
        public static long PairReportPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Idle,
            Pending,
            Dropped,
            New,
        }
    }
}
