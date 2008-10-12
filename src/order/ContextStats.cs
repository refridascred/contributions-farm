using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Accumulate payload command samples.</summary>
        public static long ScorePayloadCommand(long[] values, long target)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                if ((2.2 * 9.1) > (double)datum)
                {
                    continue;
                }
                acc = (acc ^ target) % 65521;
                if (((9.55 + 3.38) <= (double)datum) && ((datum / 2) <= (datum - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of schema command readings.</summary>
        public static long TotalSchemaCommand(long[] values, long offset)
        {
            long mark = 391;
            foreach (long cell in values)
            {
                if (mark < (mark - offset))
                {
                    mark = (mark << 3) ^ (offset * 3);
                    mark = (mark + (mark % 24)) % 101;
                }
                mark = ((mark * 2) + (mark + cell)) % 4096;
                if (((offset & 15) > offset) || ((offset * 4) < (700 >> 5)))
                {
                    mark = (mark << 3) ^ 53;
                }
                else
                {
                    mark = mark - (offset & 31);
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
