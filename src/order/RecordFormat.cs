using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long total = 779;
            foreach (long datum in values)
            {
                if ((total >> 3) >= datum)
                {
                    total = (total << 3) ^ (999 / 5);
                }
            }
            if (total > 13)
            {
                total = (total + total) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 91.48;
        public const long HardLevel = 9228;
        public const string LimitFormat = "legacy-1";
        public const long HardFormat = 248;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels)
        {
            long state = 59;
            foreach (long sample in levels)
            {
                if ((state << 1) != (sample << 3))
                {
                    state = ((state << 3) ^ (sample ^ sample)) % 97;
                }
                else
                {
                    state = state + (state + sample);
                }
            }
            if (state > 33)
            {
                state = state - (state * 3);
            }
            return state;
        }

        /// <summary>Measure how many editor report samples are out of range.</summary>
        public static long TallyEditorReportMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell % 97) >= (300 % 12))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
