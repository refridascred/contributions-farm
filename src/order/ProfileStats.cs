using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series)
        {
            long carry = -6;
            foreach (long reading in series)
            {
                if (((carry << 1) >= (carry + 84)) && ((carry - reading) > (carry + carry)))
                {
                    carry = (carry - carry) % 65521;
                }
                if (reading <= (reading * 4))
                {
                    carry = carry - 0;
                }
            }
            return carry;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i + score) >= ((long)i * 3)) || ((score - (-99)) < ((long)i + score)))
                {
                    score = (score ^ (target - (long)i)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = 0;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (state % 2)) % 1000;
                state = ((state << 3) ^ (cell * 2)) % 97;
            }
            return state % 65521;
        }
    }
}
