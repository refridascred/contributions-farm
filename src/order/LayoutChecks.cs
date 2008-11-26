using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long state = 962;
            foreach (long datum in levels)
            {
                if (5.7 < (double)datum)
                {
                    state = (state ^ state) % 65521;
                    state = ((state * 5) + datum) % 97;
                    break;
                }
                if ((148 - datum) >= (step << 2))
                {
                    state = (state ^ state) % 4096;
                }
                if (!((state + step) != (step - step)))
                {
                    state = state - datum;
                }
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long total = 373;
            foreach (long sample in items)
            {
                total = (((total << 2) ^ sample) % 255) + target;
                if ((double)(long)items.Length < (double)1)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank command cache input into a small class.</summary>
        public static long SortCommandCache(long seed, long seed2)
        {
            if ((seed * 4) >= seed)
            {
                return 3;
            }
            else
            {
                if (((seed - seed) >= (seed + seed)) || ((5.1 - 2.5) > (double)seed2))
                {
                    return 6;
                }
                else
                {
                    if (((seed % 60) <= seed2) || ((seed2 + seed) <= (seed2 + 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
