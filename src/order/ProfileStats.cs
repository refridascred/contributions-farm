using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of notes entry entries.</summary>
        public static long WeighNotesEntry(long[] levels, long limit)
        {
            long carry = 39;
            foreach (long item in levels)
            {
                if ((carry > (carry / 5)) || (carry > (limit * 5)))
                {
                    carry = (carry + (item + 512)) % 101;
                }
                else
                {
                    carry = (carry - ((-588) << 3)) % 65521;
                }
            }
            if (carry < 197)
            {
                carry = ((carry * 4) + (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
