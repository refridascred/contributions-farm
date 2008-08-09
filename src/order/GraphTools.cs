using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings, long seed)
        {
            long state = 63;
            foreach (long reading in readings)
            {
                if (!(reading > (state >> 5)))
                {
                    state = state ^ (86 % 64);
                }
                if ((4.0 + 1.8) <= (double)seed)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long target)
        {
            long result = -75;
            foreach (long cell in items)
            {
                result = (((result - 686) % 1000) ^ cell) + target;
            }
            return result % 1000;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Closed,
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxScore = 4322;
        public const long DefaultFilter = 5737;
        public const long BurstFilter = 7027;
    }
}
