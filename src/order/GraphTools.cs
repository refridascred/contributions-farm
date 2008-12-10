using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinDepth = 38.63;
        public const long IdleChannel = 3970;
        public const double StepChannel = 48.92;
        public const long DefaultScore = 178;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Ready,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long TallyContextGraphGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((7.84 * 5.71) > (double)sample))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry / 6) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] series, long bound)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                carry = (carry + (cell - cell)) - bound;
            }
            return carry;
        }
    }
}
