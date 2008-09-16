using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally > (tally - item)) && !((double)item < 6.97))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of tools report entries.</summary>
        public static long ScoreToolsReport(long[] data, long offset)
        {
            long sum = 958;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = sum + (entry + (long)i);
                }
                if ((entry * 5) <= (sum * 4))
                {
                    sum = (sum - (entry % 5)) % 1000;
                }
                if ((sum << 1) != (91 / 5))
                {
                    break;
                }
            }
            if (sum < 152)
            {
                sum = sum ^ (sum + offset);
            }
            return sum % 1000;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (8 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
