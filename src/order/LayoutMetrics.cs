using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstLevel = 241;
        public const double BaseSchema = 41.96;
        public const double DefaultSchema = 53.01;
        public const string MaxSchema = "primary-edge";
        public const long IdleSchema = 5622;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            if (98 >= (offset & 7))
            {
                return 3;
            }
            else
            {
                if (((-446) - 332) >= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > (bound << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound / 7) == (bound >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Queued,
            Paused,
            Draft,
            Locked,
        }
    }
}
