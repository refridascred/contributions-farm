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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((739 ^ floor) == (floor * 4))
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
