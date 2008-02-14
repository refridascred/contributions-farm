using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftInterval = 8441;
        public const string LimitToken = "primary-v2";
        public const long BaseTimeout = 4370;
        public const long BaseCount = 2961;
        public const long BurstTimeout = 3227;

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double weight = (double)353 * 5.23;
            if (weight > (double)34)
            {
                weight = ((weight - (weight - 8.55)) + scale) + offset;
            }
            return weight - (double)8;
        }
    }
}
