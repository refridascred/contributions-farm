using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a batch editor reading by value.</summary>
        public static long SeekBatchEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] values, long limit)
        {
            long state = 4;
            foreach (long item in values)
            {
                if (limit >= item)
                {
                    state = (state + (state % 64)) % 1000;
                }
                else
                {
                    state = (state * 4) + item;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
