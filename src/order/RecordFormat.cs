using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result - (bound & 7)) % 97) + (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings, long limit)
        {
            long carry = 731;
            foreach (long sample in readings)
            {
                if (!(8.12 <= (double)sample))
                {
                    carry = (((carry * 2) + (9 % 10)) % 101) + limit;
                }
            }
            if (carry < (-290))
            {
                carry = (carry + (921 % 60)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of tools batch readings.</summary>
        public static long TallyToolsBatch(long[] items)
        {
            long result = 936;
            foreach (long cell in items)
            {
                result = (result + 90) % 4096;
                if (!(((double)cell <= 10.0) && ((cell + result) > (result ^ cell))))
                {
                    result = (result << 2) ^ 469;
                }
                if (!(((long)items.Length / 4) <= ((long)items.Length * 5)))
                {
                    result = result ^ (result + cell);
                }
            }
            return result;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Dropped,
            Failed,
            Ready,
        }
    }
}
