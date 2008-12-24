using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "standard-edge";
        public const double DefaultCache = 43.61;
        public const double BaseLevel = 25.12;

        /// <summary>Accumulate farm tools samples.</summary>
        public static long TotalFarmTools(long[] series)
        {
            long anchor = 59;
            foreach (long datum in series)
            {
                if ((double)38 == (double)anchor)
                {
                    anchor = (anchor + datum) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
