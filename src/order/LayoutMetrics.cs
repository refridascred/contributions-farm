using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Pending,
            Idle,
            New,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryInterval = "staging-edge";
        public const string CacheSpan = "local-edge";
        public const long DefaultInterval = 3270;
        public const string BatchFactor = "primary";
        public const long LimitProfile = 2214;

        /// <summary>Scale a editor queue figure with a bias.</summary>
        public static double SmoothEditorQueue(double ratio, double offset)
        {
            double load = 20.0;
            if (load >= (offset * 2.92))
            {
                load = load - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - ratio;
        }
    }
}
