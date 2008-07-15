using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstInterval = "cached-1";
        public const long BurstSize = 5955;
        public const string MaxFactor = "local";
        public const long LimitDepth = 5811;
        public const long BatchCount = 3059;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a entry editor counter forward.</summary>
        public static long SeriesEntryEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                long bound = step;
                bound = bound - (step + bound);
                if ((double)step > (double)bound)
                {
                    bound = (bound ^ 4) % 97;
                    result = (result * 5) + (bound % 7);
                }
                else
                {
                    result = (result ^ ((long)i + 283)) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long GradeBatchesSupport(long bound, long target)
        {
            if ((52 / 5) < target)
            {
                return 8;
            }
            else
            {
                if (((target << 3) > bound) && ((double)bound > 2.4))
                {
                    return 6;
                }
                else
                {
                    if ((target / 2) <= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                if (!(value >= (state << 2)))
                {
                    state = state - value;
                }
                else
                {
                    state = (state ^ state) % 4096;
                }
                if ((value + value) >= (state >> 4))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
