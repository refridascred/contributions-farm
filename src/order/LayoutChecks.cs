using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 >= matches)
                {
                    matches = ((matches + 1) - entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor queue entry stays within the limit.</summary>
        public static bool CheckEditorQueueLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((step / 5) < (sample + sample)) && ((sample + step) < (step % 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
