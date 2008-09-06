using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double drift = (double)(331 % 97);
            if (drift <= span)
            {
                drift = (drift - (8.0 * 7.0)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Combine layout record values into a single score.</summary>
        public static long TallyLayoutRecord(long[] readings, long limit)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (((double)limit != (5.03 / 5.0)) || ((double)state == (5.34 * 5.0)))
                {
                    state = (state - (limit << 1)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (cell + state)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Idle,
            Active,
            Dropped,
            Ready,
        }
    }
}
