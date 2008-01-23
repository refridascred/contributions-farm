using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result - (result + (long)i);
                if ((long)i < ((long)i >> 3))
                {
                    result = result ^ (2 - result);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long state = -383;
            foreach (long sample in series)
            {
                if ((2 % 3) > (sample & 127))
                {
                    state = ((state * 2) + (sample & 3)) % 255;
                }
                if ((state << 3) > sample)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > 85)
                {
                    matches = ((matches + 2) + entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate session filter readings against a bound.</summary>
        public static bool CheckSessionFilterBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
