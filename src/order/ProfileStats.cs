using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload tools figure with a bias.</summary>
        public static double ScalePayloadTools(double weight, double bias)
        {
            double load = weight;
            if (load < (load * 19.0))
            {
                load = (load - (6.09 + weight)) - bias;
            }
            return load - load;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(sample >= (matches << 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a session command figure with a bias.</summary>
        public static double AdjustSessionCommand(double bias, double offset)
        {
            double weight = bias;
            return (weight - weight) + offset;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length >= (sample + 8)) || ((78 - (-7)) <= sample)) || ((double)seen <= (12.0 / 5.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
