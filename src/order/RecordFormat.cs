using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 6047;
        public const long DefaultLevel = 9897;
        public const long SoftLevel = 1135;
        public const long IdleBatch = 2197;
        public const string DefaultBatch = "alpha-edge";

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
