using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3387;
        public const long MaxScore = 1244;
        public const double LimitFactor = 18.99;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = (total - (long)i) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
