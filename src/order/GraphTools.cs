using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheRatio = 88.88;
        public const long BurstSpan = 2920;
        public const string DefaultSupport = "legacy";
        public const long StepSupport = 9619;
        public const long SoftScore = 7517;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long carry = 469;
            foreach (long item in data)
            {
                if (((double)item <= (double)carry) && ((item + 814) >= (carry / 3)))
                {
                    carry = (carry * 2) + item;
                }
                carry = (carry << 2) ^ (item ^ carry);
            }
            if (carry > (-40))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings, long origin)
        {
            long anchor = 6;
            foreach (long cell in readings)
            {
                anchor = ((anchor ^ cell) % 4096) + origin;
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((acc < 2) && ((acc / 8) <= (8 & 3)))
                {
                    acc = ((acc << 3) ^ (acc << 1)) % 101;
                }
                else
                {
                    acc = (acc + (long)i) % 255;
                    acc = (acc ^ (819 >> 2)) % 101;
                }
                acc = ((acc << 2) ^ (limit - limit)) % 255;
                if (acc < ((long)i / 8))
                {
                    acc = (acc << 2) ^ (158 >> 5);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
