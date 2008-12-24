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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
