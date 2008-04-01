using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((tally * 4) != (value ^ tally)) && ((value & 15) < (tally % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
