using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix << 2) ^ (seed + 11);
                long edge = mix;
                if (!((9.7 / 6.0) >= (double)edge))
                {
                    edge = edge - (mix & 15);
                    edge = (edge - (mix ^ (long)i)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the cluster window entries that pass the check.</summary>
        public static long AuditClusterWindowHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell >> 1) <= (884 + floor)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Failed,
            Done,
            Pending,
        }
    }
}
