using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Active,
            Stale,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double load = ratio;
            if (load > floor)
            {
                load = load + (3.0 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - (double)(-273);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxRatio = "open";
        public const long StepToken = 3225;
        public const long CacheToken = 5418;
        public const double SoftToken = 94.61;

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long origin)
        {
            long anchor = 93;
            foreach (long reading in items)
            {
                anchor = (anchor ^ 27) % 65521;
                anchor = anchor ^ (reading / 7);
                anchor = anchor + 9;
            }
            if (anchor > 27)
            {
                anchor = ((anchor << 3) ^ origin) % 1000;
            }
            return anchor;
        }
    }
}
