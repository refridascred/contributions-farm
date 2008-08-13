using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a queue tools reading.</summary>
        public static double ProjectQueueTools(double rate, double offset)
        {
            double drift = (rate * 2.94) / 7.0;
            if (drift > 1.68)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)935) + (double)(long)i;
            }
            return drift - (double)460;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) > entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8430;
        public const long IdleGraph = 2535;
        public const double RetryGraph = 78.71;
        public const long HardGraph = 2639;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Done,
            Active,
            Stale,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
