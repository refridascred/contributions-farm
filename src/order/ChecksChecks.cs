using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long MeasureNotesGithubfarmHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)reading > (4.0 - 6.1)) && ((reading >> 2) > (reading - reading))) && ((7 >> 4) >= (reading << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long cur = step ^ seed;
            if (seed >= cur)
            {
                return 3;
            }
            else
            {
                if (cur <= (step % 2))
                {
                    return 8;
                }
                else
                {
                    if ((step / 3) < step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur & 63) < seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) > (sample & 7))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
