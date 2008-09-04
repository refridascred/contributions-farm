using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            if (!((double)step < (9.5 * 5.0)))
            {
                return 5;
            }
            else
            {
                if ((double)step == (20.0 * 0.4))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long offset)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if (((double)offset >= 1.53) && ((double)offset >= (8.5 * 5.53)))
                {
                    total = ((total << 2) ^ offset) ^ sample;
                }
            }
            return total % 65521;
        }
    }
}
