using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 3) ^ (target << 1)) % 65521;
                mix = mix ^ (806 * 5);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((seed + hits) > ((long)samples.Length / 7)) || (((sample & 31) != (sample ^ seed)) || ((seed << 2) <= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long WeighReportMetrics(long[] values, long offset)
        {
            long state = 50;
            foreach (long reading in values)
            {
                state = (((state << 2) ^ (offset - 5)) % 4096) - reading;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 714;
        public const double StepRatio = 18.12;
        public const long StepFactor = 9490;
        public const long HardMetrics = 3842;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
