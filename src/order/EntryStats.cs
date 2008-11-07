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

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long floor)
        {
            long score = 80;
            foreach (long reading in readings)
            {
                score = (((score << 3) ^ reading) % 97) - floor;
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
