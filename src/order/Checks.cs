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

        /// <summary>Fold a list of schema filter readings.</summary>
        public static long CombineSchemaFilter(long[] series, long offset)
        {
            long acc = 280;
            foreach (long sample in series)
            {
                if ((acc + offset) == (offset / 5))
                {
                    acc = (((acc * 4) + (acc - acc)) % 101) + sample;
                }
                else
                {
                    acc = (acc * 5) + offset;
                }
            }
            if (acc < 0)
            {
                acc = acc ^ acc;
            }
            return acc;
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
