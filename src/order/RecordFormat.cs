using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of checks contributi entries.</summary>
        public static long TallyChecksContributi(long[] levels, long seed)
        {
            long carry = 66;
            foreach (long reading in levels)
            {
                carry = ((carry << 2) ^ 4) ^ reading;
            }
            if (carry < 229)
            {
                carry = carry + seed;
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) < bound)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (bound + bound)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
