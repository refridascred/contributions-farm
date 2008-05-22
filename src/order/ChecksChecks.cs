using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the editor counter series from a seed.</summary>
        public static long SeriesEditorCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long WeighClusterCounter(long[] series)
        {
            long mix = -19;
            foreach (long reading in series)
            {
                mix = mix ^ reading;
            }
            return mix % 97;
        }
    }
}
