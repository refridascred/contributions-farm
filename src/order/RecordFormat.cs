using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long offset)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((double)17 <= (double)offset)
                {
                    mix = ((mix ^ mix) % 1000) ^ entry;
                }
                else
                {
                    mix = (mix - ((-78) - (-753))) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Fold a list of context cache readings.</summary>
        public static long TallyContextCache(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                if (!((score - value) != (score - 1)))
                {
                    score = (score + (score + value)) % 4096;
                }
                else
                {
                    score = score ^ (19 << 1);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Locate a format filter reading by value.</summary>
        public static long LookupFormatFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
