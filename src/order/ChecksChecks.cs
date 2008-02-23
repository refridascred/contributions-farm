using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine stream batches values into a single score.</summary>
        public static long CombineStreamBatches(long[] values, long seed)
        {
            long mix = 97;
            foreach (long item in values)
            {
                mix = (((mix * 4) + mix) % 65521) + item;
            }
            if (mix < (-974))
            {
                mix = (mix ^ (seed / 7)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Locate a cluster profile reading by value.</summary>
        public static long LocateClusterProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 6202;
        public const string MinProfile = "legacy-1";
        public const long BatchProfile = 6634;
        public const long HardProfile = 2871;
        public const long SoftProfile = 8809;
    }
}
