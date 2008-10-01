using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long seed, long floor)
        {
            long next = seed + floor;
            if (seed <= floor)
            {
                return 0;
            }
            else
            {
                if (!((seed * 5) > (floor << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((double)next < 13.0)
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed >= (next % 12))
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

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Locked,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double load = scale;
            return (load - (7.88 * 8.1)) + offset;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Validate session graph readings against a bound.</summary>
        public static bool CheckSessionGraphBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
