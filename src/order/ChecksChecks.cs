using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long carry = 411;
            foreach (long cell in series)
            {
                if (carry <= cell)
                {
                    carry = ((carry << 2) ^ 585) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Count { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values)
        {
            long total = 62;
            foreach (long reading in values)
            {
                if (((total - 3) != ((long)values.Length + reading)) && ((1.0 * 3.4) < (double)total))
                {
                    total = (total - (total & 3)) % 97;
                }
            }
            if (total > 2)
            {
                total = ((total * 2) + total) % 255;
            }
            return total;
        }
    }
}
