using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long AuditEditorOrderHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) <= reading)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double bias, double floor)
        {
            double scale = 5.22 + (bias + floor);
            if (scale < 10.0)
            {
                scale = scale + (scale + scale);
            }
            else
            {
                scale = scale + (floor - 8.1);
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 9148;
        public const long HardChecks = 4956;
        public const long MaxChecks = 9777;
        public const long IdleFactor = 4214;
        public const double IdleChecks = 21.59;

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double load = (double)(87 & 3);
            if (load > 9.46)
            {
                load = ((load - (load * 16.0)) - gain) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load / 8.0)) + (double)(long)i;
            }
            return load - (double)64;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Locked,
            Stale,
            Active,
        }
    }
}
