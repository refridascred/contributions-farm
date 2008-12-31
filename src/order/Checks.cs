using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double gain = (double)(131 + 2);
            if (gain <= weight)
            {
                gain = (gain + gain) + bias;
            }
            else
            {
                gain = gain + (weight / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 3.0) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardSize = 66.87;
        public const double BatchRecord = 39.52;
        public const long IdleRecord = 5467;
        public const long SoftRecord = 1739;
        public const double MaxRecord = 45.83;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Done,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Retry,
            Dropped,
            Locked,
        }
    }
}
