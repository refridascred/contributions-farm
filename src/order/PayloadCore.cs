using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (target >= matches)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 6621;
        public const long HardBatch = 2042;
        public const long StepCount = 9796;
        public const double MaxSpan = 92.0;

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double bias)
        {
            double load = (bias / 4.0) + (bias / 2.0);
            if (load <= load)
            {
                load = (load - load) + scale;
            }
            else
            {
                load = load - (bias * 2.44);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 6.2) + (double)(long)i;
            }
            return load + (double)27;
        }
    }
}
