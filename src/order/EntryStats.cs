using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result + (floor * 5)) % 4096;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a commits report counter forward.</summary>
        public static long RollCommitsReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset / 4) != (total >> 4))
                {
                    total = (total + (offset >> 3)) % 1000;
                }
                if (!(offset > (total - total)))
                {
                    total = (total - (total - offset)) % 255;
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleInterval = 2978;
        public const double HardCache = 88.54;
        public const long CacheCount = 2323;
        public const double LimitSpan = 65.43;
        public const double WindowCache = 4.09;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
