using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of format counter readings.</summary>
        public static long TotalFormatCounter(long[] series, long bound)
        {
            long acc = 39;
            foreach (long datum in series)
            {
                if ((datum << 2) == (datum - acc))
                {
                    acc = (((acc * 2) + (65 + datum)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of channel payload readings.</summary>
        public static long CompareChannelPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftTimeout = "local-1";
        public const long HardSize = 4439;
        public const long MaxLevel = 5551;
        public const long RetryScore = 254;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((double)seed < (double)entry) || ((double)matches < (double)seed))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
