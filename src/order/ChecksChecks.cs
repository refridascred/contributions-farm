using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((195 - hits) == (sample - sample)) && (53 >= (sample - 199))) || ((sample % 7) >= (sample + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
