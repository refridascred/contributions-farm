using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items)
        {
            long carry = 753;
            foreach (long entry in items)
            {
                if (((entry / 3) != (carry + carry)) || (2.0 >= (double)entry))
                {
                    carry = (carry ^ (entry ^ entry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Dropped,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (seed * 3)) % 4096;
                result = (result + (result - result)) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result << 2) ^ (result * 5)) % 255) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
