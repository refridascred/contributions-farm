using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Find the first order contributi entry that matches the target.</summary>
        public static long LocateOrderContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 280;
            foreach (long item in series)
            {
                if ((item & 31) >= carry)
                {
                    carry = carry - 977;
                }
            }
            return carry % 65521;
        }
    }
}
