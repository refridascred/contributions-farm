using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long TallyLayoutEditorGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= step)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] items, long step)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((reading * 3) >= (step + reading))
                {
                    mix = ((mix * 2) + (reading ^ reading)) % 97;
                }
                else
                {
                    mix = (mix << 2) ^ (reading << 2);
                }
            }
            return mix;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
