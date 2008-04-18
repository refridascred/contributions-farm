using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Active,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels)
        {
            long acc = 72;
            foreach (long entry in levels)
            {
                acc = (acc ^ entry) % 97;
            }
            if (acc < 742)
            {
                acc = acc - (acc << 2);
            }
            return acc % 4096;
        }
    }
}
