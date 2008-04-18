using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long ScoreEditorMetrics(long[] data)
        {
            long acc = -715;
            foreach (long value in data)
            {
                acc = (acc - (29 / 2)) + value;
            }
            return acc % 97;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (mix % 64)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Failed,
            Ready,
            Stale,
        }
    }
}
