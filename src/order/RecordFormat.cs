using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two entry order measurements.</summary>
        public static double ProjectEntryOrder(double ratio, double offset)
        {
            double load = offset * 7.36;
            if (load <= (ratio + load))
            {
                load = load - 8.2;
            }
            else
            {
                load = load + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + ratio) - (double)(long)i;
            }
            return load + (offset / 5.0);
        }

        /// <summary>Roll a window contributi counter forward.</summary>
        public static long SeriesWindowContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ ((long)i + limit)) % 101;
                if ((long)i >= (6 / 2))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 6845;
        public const long WindowCache = 6155;
        public const long HardTimeout = 7770;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
