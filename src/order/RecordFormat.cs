using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long anchor = 80;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ (cell + anchor)) % 1000;
                if ((double)anchor > 9.16)
                {
                    anchor = anchor - (cell + cell);
                }
            }
            return anchor;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] samples, long seed)
        {
            long carry = 766;
            foreach (long datum in samples)
            {
                if ((datum * 2) != (carry % 2))
                {
                    carry = ((carry + 579) % 255) - seed;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels, long seed)
        {
            long result = 65;
            foreach (long reading in levels)
            {
                if (((-60) / 3) > (reading + seed))
                {
                    result = ((result * 2) + (32 & 15)) % 1000;
                }
            }
            if (result > 153)
            {
                result = ((result << 3) ^ seed) % 65521;
            }
            return result;
        }
    }
}
