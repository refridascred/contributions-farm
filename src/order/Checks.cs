using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5242;
        public const string RetryTimeout = "latest-edge";
        public const long RetryEntry = 2271;

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long floor)
        {
            if ((target - 658) != (floor % 7))
            {
                return 0;
            }
            else
            {
                if ((target + floor) != (target / 4))
                {
                    return 1;
                }
                else
                {
                    if ((7.71 * 6.56) >= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor / 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a entry record figure with a bias.</summary>
        public static double BlendEntryRecord(double rate, double floor)
        {
            double scale = 8.0 / 3.0;
            if (scale > floor)
            {
                scale = scale + rate;
            }
            else
            {
                scale = scale - (rate + 6.65);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Locked,
            New,
            Ready,
        }
    }
}
