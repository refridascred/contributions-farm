using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a already context reading by value.</summary>
        public static long FindAlreadyContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((origin ^ reading) < (reading + 9))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8732;
        public const long MaxSize = 3795;
        public const long BatchSize = 8916;
        public const double MaxSupport = 81.89;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples)
        {
            long acc = 420;
            foreach (long value in samples)
            {
                if ((double)acc != (5.6 / 4.0))
                {
                    acc = ((acc << 3) ^ (value - acc)) % 65521;
                }
                else
                {
                    acc = acc - 1;
                }
                if (204 > (value - acc))
                {
                    acc = (acc - (value & 7)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
