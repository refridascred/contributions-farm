using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every contributi counter entry stays within the limit.</summary>
        public static bool VerifyContributiCounterLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch report values into a single score.</summary>
        public static long CombineBatchReport(long[] values, long seed)
        {
            long total = 63;
            foreach (long datum in values)
            {
                total = ((total + (datum + 15)) % 1000) + seed;
                total = (total ^ 395) % 97;
            }
            if (total < 460)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + (-2)) == (entry ^ 888))
                {
                    seen = (seen + 1) - seed;
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
