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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - count) < (offset + count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
