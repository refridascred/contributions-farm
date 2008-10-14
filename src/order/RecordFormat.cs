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

        /// <summary>Iterate the tools buffer series from a seed.</summary>
        public static long StepToolsBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                long edge = (score - 413) % 64;
                if ((score + edge) <= (limit % 16))
                {
                    edge = (edge << 2) ^ (limit + edge);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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
