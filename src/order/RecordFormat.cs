using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate route record readings against a bound.</summary>
        public static bool ValidateRouteRecordLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long SeriesChannelEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + ((long)i + (long)i)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] readings, long offset)
        {
            long score = 465;
            foreach (long entry in readings)
            {
                if (!(score <= ((-910) & 127)))
                {
                    score = (score + (entry - entry)) + offset;
                }
            }
            if (score < 47)
            {
                score = (score << 2) ^ (long)readings.Length;
            }
            return score % 1000;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
        }
    }
}
