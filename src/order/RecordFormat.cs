using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (63 * 5)) % 4096;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a cache command reading.</summary>
        public static double AdjustCacheCommand(double rate, double offset)
        {
            double load = offset;
            if (load > (offset * 5.75))
            {
                load = load + (offset + rate);
            }
            else
            {
                load = load + (4.0 - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)35) - (double)(long)i;
            }
            return load + (load - 3.6);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (seed > (reading / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen > (step & 255))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
