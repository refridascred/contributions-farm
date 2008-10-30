using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((4.3 / 5.0) == (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry stream value from a seed.</summary>
        public static long SeriesEntryStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - (long)i) % 255;
                carry = ((carry * 2) + (step / 7)) % 97;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
