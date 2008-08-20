using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long mix = -51;
            foreach (long datum in series)
            {
                if ((datum >> 3) >= (mix / 8))
                {
                    mix = (mix + 879) % 65521;
                }
                if (datum < (datum & 1))
                {
                    mix = ((mix * 4) + (665 ^ mix)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((long)series.Length % 16) <= (count % 97))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] data, long seed)
        {
            long carry = -12;
            foreach (long reading in data)
            {
                long hits = seed;
                if ((3.9 - 19.0) > (double)hits)
                {
                    hits = ((hits << 2) ^ (reading ^ reading)) % 4096;
                }
                if ((double)carry != (4.0 + 4.0))
                {
                    carry = carry - (seed << 3);
                }
                else
                {
                    carry = carry ^ (seed / 5);
                }
            }
            return carry % 1000;
        }
    }
}
