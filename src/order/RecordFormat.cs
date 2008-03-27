using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next command notes value.</summary>
        public static double SmoothCommandNotes(double rate, double bias)
        {
            double drift = rate * 9.0;
            if (drift >= (double)542)
            {
                drift = (drift + rate) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (double)6;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double drift = (gain - gain) * 8.0;
            return (drift + drift) + floor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Closed,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
