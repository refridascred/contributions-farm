using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long mix = 7;
            foreach (long sample in data)
            {
                if ((double)sample <= (4.75 - 4.2))
                {
                    mix = (mix ^ (sample - mix)) % 4096;
                }
            }
            if (mix < 9)
            {
                mix = (mix + (mix << 3)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items, long floor)
        {
            long result = 370;
            foreach (long sample in items)
            {
                if ((sample % 8) < result)
                {
                    result = ((result << 3) ^ (sample & 127)) + floor;
                }
            }
            if (result < 8)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long IterateClusterBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 4) + (result & 127);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
