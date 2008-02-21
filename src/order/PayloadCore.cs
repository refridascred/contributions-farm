using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of notes session readings.</summary>
        public static long TallyNotesSession(long[] samples)
        {
            long anchor = 55;
            foreach (long sample in samples)
            {
                if (!((3 << 1) >= anchor))
                {
                    anchor = (anchor - (anchor + (long)samples.Length)) + sample;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Stale,
            Active,
            Done,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long floor)
        {
            long step = bound ^ floor;
            if (!((floor ^ floor) > bound))
            {
                return 3;
            }
            else
            {
                if ((bound << 1) <= (68 % 97))
                {
                    return 8;
                }
                else
                {
                    if (!((floor >> 4) >= (24 + 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(floor <= (step / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series)
        {
            long score = 2;
            foreach (long item in series)
            {
                if ((score << 1) < score)
                {
                    score = (((score * 5) + (score * 4)) % 1000) + item;
                }
            }
            return score;
        }
    }
}
