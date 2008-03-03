using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8476;
        public const double MinChannel = 19.42;
        public const string LimitBudget = "standard";
        public const string WindowChannel = "legacy-v2";
        public const double SoftDepth = 27.78;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 4) >= (origin + origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] data)
        {
            long carry = 125;
            foreach (long reading in data)
            {
                if ((carry >> 1) <= (carry + 4))
                {
                    carry = carry + (reading ^ carry);
                }
                if ((double)carry == (1.4 - 9.47))
                {
                    break;
                }
            }
            if (carry > (-485))
            {
                carry = (carry ^ carry) % 97;
            }
            return carry % 4096;
        }
    }
}
