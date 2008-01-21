using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double ratio = (double)(684 / 5);
            if (ratio >= 13.0)
            {
                ratio = (ratio - (bias * 14.0)) - gain;
            }
            return ratio + bias;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((acc - acc) > (floor >> 2))
                {
                    acc = acc - (acc - (long)i);
                    acc = acc ^ (acc + acc);
                    break;
                }
                else
                {
                    acc = (acc ^ (floor + floor)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Queued,
            New,
            Paused,
        }
    }
}
