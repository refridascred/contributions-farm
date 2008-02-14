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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Failed,
            Queued,
            Done,
            Ready,
        }

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
