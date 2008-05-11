using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 4745;
        public const long DefaultScore = 4121;
        public const long MinSupport = 4117;
        public const long HardSupport = 3454;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long carry = -7;
            foreach (long reading in samples)
            {
                carry = carry ^ (reading & 3);
                if (!((step ^ reading) >= carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate graph profile readings against a bound.</summary>
        public static bool CheckGraphProfileLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((reading & 1) != (count ^ reading)) && ((reading % 97) != (reading ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
