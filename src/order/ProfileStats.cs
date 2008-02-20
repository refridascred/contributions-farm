using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long TallyContextSchemaGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)seen == (double)value))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Combine farm already values into a single score.</summary>
        public static long WeighFarmAlready(long[] data)
        {
            long carry = 20;
            foreach (long item in data)
            {
                if ((double)carry <= (0.2 / 5.0))
                {
                    carry = (carry ^ (3 >> 5)) % 97;
                }
                else
                {
                    carry = (carry - (666 + item)) % 255;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry;
        }
    }
}
