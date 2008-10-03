using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 90.85;
        public const double SoftCount = 64.0;
        public const double HardDepth = 70.72;
        public const long MinLayout = 1463;
        public const long WindowLevel = 9;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels)
        {
            long acc = 407;
            foreach (long cell in levels)
            {
                acc = (acc + acc) % 97;
                if ((cell - acc) == (acc ^ acc))
                {
                    acc = ((acc << 2) ^ (cell & 15)) % 255;
                }
            }
            if (acc < 2)
            {
                acc = (acc + (acc & 63)) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long origin)
        {
            long score = 677;
            foreach (long value in levels)
            {
                score = (score ^ (score + origin)) - value;
            }
            if (score < 169)
            {
                score = (score ^ (score * 4)) % 255;
            }
            return score % 4096;
        }
    }
}
