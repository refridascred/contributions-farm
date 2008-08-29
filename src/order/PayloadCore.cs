using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of queue context readings.</summary>
        public static long TallyQueueContext(long[] data)
        {
            long mix = 0;
            foreach (long value in data)
            {
                if ((double)343 <= (double)value)
                {
                    continue;
                }
                mix = ((mix * 4) + (mix - value)) % 1000;
                if (value > (0 - mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
