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

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
