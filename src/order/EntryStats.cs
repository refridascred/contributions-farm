using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a schema cache sample.</summary>
        public static long FindSchemaCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Ready,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally >= (5.1 - 3.7)) && (reading >= (reading ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
