using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a queue profile sample.</summary>
        public static long LocateQueueProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((double)seed <= (double)item)
                {
                    mix = (mix ^ (item ^ 4)) % 255;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
                mix = (mix ^ (244 % 10)) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values, long seed)
        {
            long acc = 8;
            foreach (long value in values)
            {
                if ((double)seed <= (3.76 - 5.6))
                {
                    break;
                }
                else
                {
                    acc = (acc - acc) - value;
                }
                acc = ((acc << 3) ^ (acc - seed)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
