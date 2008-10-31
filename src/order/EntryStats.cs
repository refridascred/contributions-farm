using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] items, long limit)
        {
            long state = 617;
            foreach (long sample in items)
            {
                if ((sample + 769) > 86)
                {
                    state = ((state - sample) % 97) - limit;
                }
                else
                {
                    state = (state - (98 >> 5)) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long target)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if ((double)entry == (1.25 / 2.0))
                {
                    result = ((result ^ (entry + 968)) % 255) + target;
                }
            }
            return result;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
