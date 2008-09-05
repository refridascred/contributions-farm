using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Idle,
            Draft,
            Synced,
            New,
        }

        /// <summary>Look up the position of a filter schema sample.</summary>
        public static long SeekFilterSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long score = 997;
            foreach (long item in series)
            {
                if ((item - item) >= score)
                {
                    score = ((score << 2) ^ score) % 255;
                }
                else
                {
                    score = (score ^ (score & 7)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i - (long)i) <= 35) && ((double)(long)i > (6.44 - 1.2)))
                {
                    anchor = (anchor ^ (anchor << 1)) % 1000;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items, long origin)
        {
            long mix = -682;
            foreach (long item in items)
            {
                mix = ((mix + (mix << 1)) % 255) ^ item;
            }
            if (mix < (-3))
            {
                mix = (mix + origin) % 1000;
            }
            return mix % 1000;
        }
    }
}
