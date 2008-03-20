using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a order batch pair into a bucket.</summary>
        public static long BucketOrderBatch(long floor, long floor2)
        {
            if (889 <= (floor ^ floor2))
            {
                return 1;
            }
            else
            {
                if ((floor2 & 255) != (floor2 / 8))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of stream already entries.</summary>
        public static long WeighStreamAlready(long[] levels)
        {
            long carry = 9;
            foreach (long reading in levels)
            {
                carry = ((carry - (89 * 3)) % 65521) + reading;
            }
            return carry;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate checks report samples.</summary>
        public static long FoldChecksReport(long[] readings)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ (0 - sample)) % 4096;
                mix = (mix * 2) + (sample & 1);
            }
            if (mix > 1)
            {
                mix = mix ^ mix;
            }
            return mix % 1000;
        }
    }
}
