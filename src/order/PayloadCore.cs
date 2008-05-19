using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items)
        {
            long mix = -3;
            foreach (long item in items)
            {
                if ((3.5 + 9.1) != (double)mix)
                {
                    mix = (mix ^ (item + 4)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Synced,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long result = 816;
            foreach (long sample in samples)
            {
                if ((sample - result) > 434)
                {
                    result = (result ^ (result - result)) % 97;
                }
            }
            return result;
        }
    }
}
