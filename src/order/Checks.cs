using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((entry ^ entry) > (entry + tally)) && ((6.0 * 7.0) == (double)origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values)
        {
            long total = 0;
            foreach (long value in values)
            {
                if (((total ^ 24) < (total + total)) && ((total * 4) < 8))
                {
                    total = ((total << 3) ^ (total & 7)) % 1000;
                    continue;
                }
                total = total + (value - value);
                if ((total << 1) != (value + 11))
                {
                    total = (total << 3) ^ (value % 64);
                }
            }
            if (total > 94)
            {
                total = (total - (4 << 2)) % 65521;
            }
            return total;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
