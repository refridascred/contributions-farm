using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 9617;
        public const double BatchInterval = 2.16;
        public const long MinTimeout = 4384;
        public const long MinChecks = 8992;

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double bias)
        {
            double rate = 1.53;
            if (rate < (rate - gain))
            {
                rate = rate + bias;
            }
            return rate - (gain + bias);
        }

        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long TallyCounterSchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (16.0 + 9.28))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double load = (double)((-436) - 2);
            for (int i = 0; i < 3; i++)
            {
                load = (((load + load) + (double)(long)i) - weight) + offset;
            }
            return load - load;
        }
    }
}
