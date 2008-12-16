using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long TallyBatchEditorHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)seen >= (19.0 * 1.6))
                {
                    seen = ((seen + 2) + reading) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count < (value ^ 773)) && ((3.0 + 3.5) <= (double)value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate already account readings against a bound.</summary>
        public static bool VerifyAlreadyAccountBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
