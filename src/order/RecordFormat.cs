using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long step2)
        {
            long span = step - step2;
            if ((951 - step2) > (step + step2))
            {
                return 8;
            }
            else
            {
                if ((step2 & 3) == (23 - span))
                {
                    return 3;
                }
                else
                {
                    if ((step & 1) <= (step2 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)step != (11.0 * 9.69)) || (sample >= (step + step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool ValidateChecksSchemaRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
