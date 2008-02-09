using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Pending,
            New,
            Draft,
        }

        /// <summary>Audit schema command readings against a rule.</summary>
        public static long MeasureSchemaCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (0.75 - 0.25))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit profile checks readings against a rule.</summary>
        public static long TallyProfileChecksGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((hits - step) <= (step - hits)) || ((double)7 <= (double)hits)))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }
    }
}
