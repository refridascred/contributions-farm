using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound << 1) <= ((long)i - (long)i))
                {
                    acc = (acc + bound) % 97;
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepTimeout = "staging-1";
        public const double IdleContributi = 56.43;
        public const double DefaultContributi = 1.42;
        public const string MinContributi = "alpha";
        public const string SoftContributi = "stable-v2";

        /// <summary>Compare every pair of layout token readings.</summary>
        public static long PairLayoutTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
