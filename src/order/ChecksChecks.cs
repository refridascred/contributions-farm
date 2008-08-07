using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batch editor reading by value.</summary>
        public static long FindBatchEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                if ((score + score) != (datum + 1))
                {
                    score = ((score << 3) ^ (score << 3)) % 4096;
                }
            }
            return score;
        }
    }
}
