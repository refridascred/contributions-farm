using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (datum + tally))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
