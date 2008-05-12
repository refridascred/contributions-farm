using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double floor)
        {
            double load = floor;
            if (load <= (load - gain))
            {
                load = load - (double)0;
            }
            else
            {
                load = load - (6.39 - gain);
            }
            return load - floor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6568;
        public const long WindowAlready = 1028;
        public const long CacheInterval = 2946;
        public const long CacheAlready = 483;
        public const long MinBudget = 8109;

        /// <summary>Validate format editor readings against a bound.</summary>
        public static bool CheckFormatEditorRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
