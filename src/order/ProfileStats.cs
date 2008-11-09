using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Draft,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of entry profile readings.</summary>
        public static long CombineEntryProfile(long[] levels, long offset)
        {
            long mark = 214;
            foreach (long entry in levels)
            {
                mark = mark ^ entry;
                mark = ((mark << 3) ^ (offset / 4)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a editor account sample.</summary>
        public static long SeekEditorAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
