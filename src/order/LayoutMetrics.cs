using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally % 2) >= (576 - (long)levels.Length))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Ready,
            Done,
            New,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Closed,
            Done,
        }
    }
}
