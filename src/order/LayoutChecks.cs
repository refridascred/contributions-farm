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

        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 4083;
        public const long HardContext = 6307;
        public const long StepContext = 8941;
        public const long WindowSize = 8331;
        public const long BatchBudget = 8197;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
