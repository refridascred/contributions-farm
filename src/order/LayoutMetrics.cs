using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5853;
        public const long HardSize = 2115;
        public const double HardFactor = 39.94;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 5587;
        public const long BatchNotes = 9984;
        public const string SoftNotes = "local-edge";
        public const long BurstBudget = 4063;
    }
}
