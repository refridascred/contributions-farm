using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] series, long step)
        {
            long anchor = -680;
            foreach (long sample in series)
            {
                if ((long)series.Length <= (sample ^ step))
                {
                    anchor = ((anchor * 4) + (anchor ^ 2)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Active,
            Paused,
            New,
        }

        /// <summary>Scale a batches metrics figure with a bias.</summary>
        public static double ProjectBatchesMetrics(double scale, double floor)
        {
            double load = scale;
            if (load <= floor)
            {
                load = load + (load - 5.8);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (floor - load)) - (double)(long)i;
            }
            return load + (load / 4.0);
        }

        /// <summary>Derive the next commits already value from a seed.</summary>
        public static long RollCommitsAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + (acc >> 4);
                long matches = acc;
                if (((limit - limit) != (limit + (-247))) || ((matches + 8) >= (acc - matches)))
                {
                    acc = (acc << 3) ^ ((long)i & 63);
                    matches = (matches * 3) + limit;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
