using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset - (long)i) == (long)i)
                {
                    result = ((result << 2) ^ (result ^ result)) % 97;
                    result = result ^ (result + offset);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] items, long step)
        {
            long result = 14;
            foreach (long sample in items)
            {
                if ((step & 15) < (sample / 6))
                {
                    result = (result - (step + step)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            if (123 <= (bound << 1))
            {
                return 7;
            }
            else
            {
                if (seed > (-26))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
