using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Locked,
            Dropped,
            Failed,
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

        /// <summary>Define account limits and defaults.</summary>
        public const string MinDepth = "strict-edge";
        public const long BaseAccount = 2522;
        public const double RetryBudget = 27.6;

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
