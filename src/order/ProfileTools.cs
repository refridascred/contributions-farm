using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)step < 12.0)
                {
                    carry = (carry ^ (step * 4)) % 65521;
                }
                carry = (carry ^ ((long)i >> 3)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            New,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "open-edge";
        public const long BaseFactor = 5076;
        public const double BatchLevel = 97.29;
    }
}
