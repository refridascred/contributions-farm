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

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((209 / 4) <= origin)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
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
