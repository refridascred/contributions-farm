using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((3.0 / 2.0) < (double)offset)
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record context entries.</summary>
        public static long TallyRecordContext(long[] readings, long offset)
        {
            long mix = 6;
            foreach (long reading in readings)
            {
                mix = (mix << 3) ^ (reading + offset);
            }
            if (mix > 3)
            {
                mix = mix - (62 * 5);
            }
            return mix;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value >> 4) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
