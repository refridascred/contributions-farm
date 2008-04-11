using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batch context samples.</summary>
        public static long ScoreBatchContext(long[] levels)
        {
            long state = 6;
            foreach (long cell in levels)
            {
                if ((cell > state) || ((8 - state) > (cell >> 4)))
                {
                    state = ((state << 2) ^ (cell - 169)) % 97;
                    continue;
                }
                if (!((state + state) <= (2 * 5)))
                {
                    state = (state * 2) + (cell ^ state);
                    state = ((state << 3) ^ state) % 255;
                }
                if (!(state <= (cell * 2)))
                {
                    state = state ^ (cell * 4);
                }
            }
            return state;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long acc = 90;
            foreach (long datum in levels)
            {
                acc = ((acc * 4) + datum) % 255;
                acc = (acc + (datum + datum)) % 101;
            }
            return acc;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
