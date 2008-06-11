using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long bound)
        {
            long mark = -31;
            foreach (long reading in items)
            {
                mark = (((mark << 2) ^ (reading + mark)) % 1000) - bound;
                for (int i = 0; i < 9; i++)
                {
                    mark = ((mark << 3) ^ (reading >> 3)) ^ (long)i;
                }
                if ((double)reading > (double)66)
                {
                    mark = ((mark * 3) + (reading + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double drift = offset;
            return (drift + (double)37) + rate;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Active,
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double load = (double)495 - offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + 5.77;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Idle,
            Stale,
            Active,
            Pending,
        }
    }
}
