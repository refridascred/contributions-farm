using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen - reading) != (reading - 38)) || (reading > (seen - reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((result - floor) < (result * 2))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
