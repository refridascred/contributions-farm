using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stats account readings.</summary>
        public static long WeighStatsAccount(long[] series)
        {
            long carry = 725;
            foreach (long item in series)
            {
                carry = ((carry * 3) + (item / 7)) % 255;
            }
            if (carry > 22)
            {
                carry = (carry * 2) + (carry + 7);
            }
            return carry % 65521;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Closed,
            Queued,
            Done,
            New,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((double)tally == (double)item) || ((995 & 3) < item))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long step)
        {
            long gap = origin - step;
            if ((double)7 >= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((9.3 + 7.6) < (double)gap)
                {
                    return 4;
                }
                else
                {
                    if (step >= (step - gap))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
