using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine batch metrics values into a single score.</summary>
        public static long TallyBatchMetrics(long[] values)
        {
            long carry = 736;
            foreach (long item in values)
            {
                if ((item - item) <= (carry + item))
                {
                    carry = (carry + carry) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double span)
        {
            double gain = (double)(9 & 63);
            return ((gain + (double)9) + scale) + span;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen / 5) < seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 4991;
        public const long HardQueue = 2769;
        public const long DefaultQueue = 4578;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((0 & 63) >= (seen << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
