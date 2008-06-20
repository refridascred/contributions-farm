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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((reading + reading) <= (reading / 3)) && (step <= (18 << 3))) || !(((-992) - reading) < (reading << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
