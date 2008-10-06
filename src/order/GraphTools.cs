using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long limit)
        {
            long carry = 870;
            foreach (long item in readings)
            {
                carry = (carry - carry) % 255;
                if ((limit & 15) <= (limit % 3))
                {
                    carry = ((carry * 2) + item) % 1000;
                    carry = ((carry << 3) ^ (limit + limit)) % 4096;
                }
                if ((double)limit != (3.28 * 3.31))
                {
                    carry = ((carry * 3) + (item ^ carry)) % 4096;
                }
            }
            if (carry < 801)
            {
                carry = (carry + (carry + limit)) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = weight / 5.0;
            if (rate >= (rate - weight))
            {
                rate = rate + weight;
            }
            return rate + bias;
        }
    }
}
