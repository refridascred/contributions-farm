using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double ratio, double floor)
        {
            double drift = (floor * 15.0) - floor;
            if (drift >= (floor / 6.0))
            {
                drift = (drift - (double)614) + ratio;
            }
            else
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (floor * 4.72);
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((floor + floor2) <= (10 - floor))
            {
                return 2;
            }
            else
            {
                if ((floor2 + offset) == (floor2 + 1))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor > (0.9 + 8.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor2 > (8.4 / 4.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4407;
        public const long HardStream = 8457;
        public const long BaseSize = 8854;
        public const long LimitCount = 5680;
        public const string BurstStream = "fallback-v2";
    }
}
