using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] values)
        {
            long mix = -272;
            foreach (long cell in values)
            {
                if (mix < (cell + mix))
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
