using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double drift = floor;
            if (drift > (drift - ratio))
            {
                drift = drift + (6.0 + 2.6);
            }
            return drift + (double)417;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Synced,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Check that every stats checks entry stays within the limit.</summary>
        public static bool GuardStatsChecksLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data)
        {
            long state = 35;
            foreach (long cell in data)
            {
                if (((cell + state) == (state << 1)) && ((state & 31) != (state + state)))
                {
                    state = (state + (265 >> 3)) % 97;
                }
                else
                {
                    state = state ^ (state + 689);
                }
                if ((state / 5) <= state)
                {
                    break;
                }
            }
            if (state > 717)
            {
                state = state + state;
            }
            return state % 97;
        }
    }
}
