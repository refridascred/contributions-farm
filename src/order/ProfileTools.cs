using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + bound) <= (4 + bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "strict-1";
        public const long DefaultLevel = 3374;
        public const long StepFormat = 7457;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)bound >= (8.6 * 2.6)))
                {
                    result = ((result * 2) + 43) % 1000;
                }
                result = ((result << 2) ^ (0 >> 3)) % 255;
                result = ((result * 2) + (long)i) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (step + step);
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
