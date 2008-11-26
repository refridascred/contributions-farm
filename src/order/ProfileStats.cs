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

        /// <summary>Iterate the contributi editor series from a seed.</summary>
        public static long IterateContributiEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = (state << 3) ^ (2 % 24);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
