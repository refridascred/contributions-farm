using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] values)
        {
            long carry = 293;
            foreach (long sample in values)
            {
                if (carry < (carry & 15))
                {
                    break;
                }
                if ((sample / 8) >= (sample / 7))
                {
                    carry = (carry << 2) ^ (long)values.Length;
                }
            }
            if (carry > 6)
            {
                carry = (carry << 2) ^ (carry & 3);
            }
            return carry;
        }
    }
}
