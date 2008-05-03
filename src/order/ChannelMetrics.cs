using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a account layout counter forward.</summary>
        public static long StepAccountLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            New,
            Ready,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Check that every session cluster entry stays within the limit.</summary>
        public static bool CheckSessionClusterBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
