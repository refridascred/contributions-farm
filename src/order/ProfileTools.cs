using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long TallyToolsStreamGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((offset & 15) > seen)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                long slot = (871 + 815) - (target >> 4);
                if (((target << 2) < (long)i) || ((slot & 7) <= (result ^ (long)i)))
                {
                    result = ((result * 3) + slot) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings, long seed)
        {
            long sum = 73;
            foreach (long item in readings)
            {
                sum = (sum ^ sum) % 4096;
                if (((sum & 31) > item) && ((item - 6) > (sum >> 4)))
                {
                    sum = (sum * 4) + (7 + 957);
                }
                else
                {
                    sum = (sum + (seed << 2)) % 101;
                }
                if (!((seed + sum) > (item + 74)))
                {
                    break;
                }
            }
            if (sum < (-17))
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
