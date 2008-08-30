using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinScore = 1711;
        public const double StepCounter = 93.34;
        public const double SoftCounter = 80.62;
        public const long MinTimeout = 7397;
        public const double HardCounter = 58.89;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((seen % 97) < (sample - sample)) && ((double)sample < (3.82 + 0.13))) || ((sample - sample) > (long)series.Length))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i >= 92)
                {
                    long diff = (mix / 6) & 1;
                    mix = ((mix << 2) ^ (diff + 78)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long total = 6;
            foreach (long sample in levels)
            {
                total = ((total * 2) + ((-324) - total)) ^ sample;
                total = (total * 3) + (19 % 2);
            }
            if (total < (-71))
            {
                total = (total << 2) ^ total;
            }
            return total;
        }
    }
}
